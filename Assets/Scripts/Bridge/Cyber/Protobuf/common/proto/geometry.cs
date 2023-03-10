// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: geometry.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.common
{

    [global::ProtoBuf.ProtoContract()]
    public partial class PointENU : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PointENU()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(double.NaN)]
        public double x
        {
            get { return __pbn__x ?? double.NaN; }
            set { __pbn__x = value; }
        }
        public bool ShouldSerializex()
        {
            return __pbn__x != null;
        }
        public void Resetx()
        {
            __pbn__x = null;
        }
        private double? __pbn__x;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(double.NaN)]
        public double y
        {
            get { return __pbn__y ?? double.NaN; }
            set { __pbn__y = value; }
        }
        public bool ShouldSerializey()
        {
            return __pbn__y != null;
        }
        public void Resety()
        {
            __pbn__y = null;
        }
        private double? __pbn__y;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double z
        {
            get { return __pbn__z ?? 0; }
            set { __pbn__z = value; }
        }
        public bool ShouldSerializez()
        {
            return __pbn__z != null;
        }
        public void Resetz()
        {
            __pbn__z = null;
        }
        private double? __pbn__z;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PointLLH : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PointLLH()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(double.NaN)]
        public double lon
        {
            get { return __pbn__lon ?? double.NaN; }
            set { __pbn__lon = value; }
        }
        public bool ShouldSerializelon()
        {
            return __pbn__lon != null;
        }
        public void Resetlon()
        {
            __pbn__lon = null;
        }
        private double? __pbn__lon;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(double.NaN)]
        public double lat
        {
            get { return __pbn__lat ?? double.NaN; }
            set { __pbn__lat = value; }
        }
        public bool ShouldSerializelat()
        {
            return __pbn__lat != null;
        }
        public void Resetlat()
        {
            __pbn__lat = null;
        }
        private double? __pbn__lat;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double height
        {
            get { return __pbn__height ?? 0; }
            set { __pbn__height = value; }
        }
        public bool ShouldSerializeheight()
        {
            return __pbn__height != null;
        }
        public void Resetheight()
        {
            __pbn__height = null;
        }
        private double? __pbn__height;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Point2D : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Point2D()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(double.NaN)]
        public double x
        {
            get { return __pbn__x ?? double.NaN; }
            set { __pbn__x = value; }
        }
        public bool ShouldSerializex()
        {
            return __pbn__x != null;
        }
        public void Resetx()
        {
            __pbn__x = null;
        }
        private double? __pbn__x;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(double.NaN)]
        public double y
        {
            get { return __pbn__y ?? double.NaN; }
            set { __pbn__y = value; }
        }
        public bool ShouldSerializey()
        {
            return __pbn__y != null;
        }
        public void Resety()
        {
            __pbn__y = null;
        }
        private double? __pbn__y;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Point3D : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Point3D()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(double.NaN)]
        public double x
        {
            get { return __pbn__x ?? double.NaN; }
            set { __pbn__x = value; }
        }
        public bool ShouldSerializex()
        {
            return __pbn__x != null;
        }
        public void Resetx()
        {
            __pbn__x = null;
        }
        private double? __pbn__x;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(double.NaN)]
        public double y
        {
            get { return __pbn__y ?? double.NaN; }
            set { __pbn__y = value; }
        }
        public bool ShouldSerializey()
        {
            return __pbn__y != null;
        }
        public void Resety()
        {
            __pbn__y = null;
        }
        private double? __pbn__y;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(double.NaN)]
        public double z
        {
            get { return __pbn__z ?? double.NaN; }
            set { __pbn__z = value; }
        }
        public bool ShouldSerializez()
        {
            return __pbn__z != null;
        }
        public void Resetz()
        {
            __pbn__z = null;
        }
        private double? __pbn__z;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Quaternion : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Quaternion()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(double.NaN)]
        public double qx
        {
            get { return __pbn__qx ?? double.NaN; }
            set { __pbn__qx = value; }
        }
        public bool ShouldSerializeqx()
        {
            return __pbn__qx != null;
        }
        public void Resetqx()
        {
            __pbn__qx = null;
        }
        private double? __pbn__qx;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(double.NaN)]
        public double qy
        {
            get { return __pbn__qy ?? double.NaN; }
            set { __pbn__qy = value; }
        }
        public bool ShouldSerializeqy()
        {
            return __pbn__qy != null;
        }
        public void Resetqy()
        {
            __pbn__qy = null;
        }
        private double? __pbn__qy;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(double.NaN)]
        public double qz
        {
            get { return __pbn__qz ?? double.NaN; }
            set { __pbn__qz = value; }
        }
        public bool ShouldSerializeqz()
        {
            return __pbn__qz != null;
        }
        public void Resetqz()
        {
            __pbn__qz = null;
        }
        private double? __pbn__qz;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(double.NaN)]
        public double qw
        {
            get { return __pbn__qw ?? double.NaN; }
            set { __pbn__qw = value; }
        }
        public bool ShouldSerializeqw()
        {
            return __pbn__qw != null;
        }
        public void Resetqw()
        {
            __pbn__qw = null;
        }
        private double? __pbn__qw;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Polygon : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Polygon()
        {
            point = new global::System.Collections.Generic.List<Point3D>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<Point3D> point { get; private set; }

    }

}

#pragma warning restore 0612, 1591, 3021
