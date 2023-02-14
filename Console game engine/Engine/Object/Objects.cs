﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public abstract void Load();
        public abstract void Awake();
        public abstract void Update();
    }
}
