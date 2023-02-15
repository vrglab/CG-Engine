﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Object.PremadeComponents;

namespace Engine.Object
{
    public abstract class Object : Instanceable, IEquatable<Object>
    {
        private int hashcode;

        protected Object()
        {
            HashCode hc = new HashCode();
            hc.Add(this);
            hc.Add(GetInstanceId());
            hashcode = hc.ToHashCode();
        }

        public bool Equals(Object? other)
        {
            if (other.hashcode == hashcode && other.GetInstanceId() == GetInstanceId())
            {
                return true;
            }

            return false;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Object);
        }

        public override int GetHashCode()
        {
            return hashcode;
        }

        public override string? ToString()
        {
            return "Object: " + GetInstanceId();
        }

        public static bool operator ==(Object? left, Object? right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Object? left, Object? right)
        {
            if (left.Equals(right))
            {
                return false;
            }
            return true;
        }
    }

    public abstract class Instanceable : object
    {
        private Guid InstanceId { get; }

        protected Instanceable()
        {
            InstanceId = Guid.NewGuid();
        }

        public Guid GetInstanceId()
        {
            return InstanceId;
        }
    }

    public abstract class GameObject : Object
    {
        private List<Component> RegisteredComponents = new List<Component>();

        public Transform transform { get; private set; }

        protected GameObject()
        {
            transform = AddComponant<Transform>();
        }

        public virtual void Load()
        {
            foreach (var comp in RegisteredComponents)
            {
                comp.Load();
            }
        }
        public virtual void Awake()
        {
            foreach (var comp in RegisteredComponents)
            {
                comp.Awake();
            }
        }
        public virtual void Update()
        {
            foreach (var comp in RegisteredComponents)
            {
                comp.Update();
            }
        }
        public virtual void Render()
        {
            foreach (var comp in RegisteredComponents)
            {
                comp.Render();
            }
        }

        public t AddComponant<t>() where t : Component, new()
        {
            var Refrenace = new t
            {
                gameobject = this
            };
            Refrenace.Awake();
            RegisteredComponents.Add(Refrenace);
            return Refrenace;
        }

        public t AddComponant<t>(t Refrenace) where t : Component, new()
        {
            Refrenace.Awake();
            RegisteredComponents.Add(Refrenace);
            return Refrenace;
        }

        public t? GetComponant<t>() where t : Component
        {
            foreach (var item in RegisteredComponents)
            {
                if (item is t)
                {
                    return item as t;
                }
            }
            return default;
        }

        public t[] GetComponants<t>() where t : Component
        {
            List<t> list = new List<t>();
            foreach (var item in RegisteredComponents)
            {
                if (item is t)
                {
                    list.Add(item as t);
                }
            }
            return list.ToArray();
        }

        public void RemoveComponant<t>() where t : Component
        {
            Component removed = null;
            foreach (var item in RegisteredComponents)
            {
                if (item is t)
                {
                    removed = item;
                }
            }
            RegisteredComponents.Remove(removed);
        }
    }
}
