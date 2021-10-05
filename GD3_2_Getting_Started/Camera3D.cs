using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace GDLibrary.Actor
{
    public class Camera3D : Actor
    {
        private float fieldOfView, aspectRatio;
        private Vector3 look, up;

        //to do - Properties, ToString, Clone, DeepClone

        public Camera3D(Vector3 translation,
            float fieldOfView, float aspectRatio,
            Vector3 look, Vector3 up) : base(translation)
        {
            this.fieldOfView = fieldOfView;
            this.aspectRatio = aspectRatio;
            this.look = look;
            this.up = up;
        }

        public new string ToString()
        {
            return base.ToString()
                + ","
                + fieldOfView
                 + ","
                + aspectRatio
                 + ","
                + look
                 + ","
                + up;
        }
    }
}