using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    //MainCameraにスクリプト入れる
    private GameObject player;
    private float pos1;
    private float pos2;
    public float a1;
    public float a2;
    public float b1;
    public float b2;
    public float ax;
    public float ay;
    public float az;
    public float c1;
    public float c2;
    public float d1;
    public float d2;
    public float bx;
    public float by;
    public float bz;
    public float e1;
    public float e2;
    public float f1;
    public float f2;
    public float cx;
    public float cy;
    public float cz;
    public float g1;
    public float g2;
    public float h1;
    public float h2;
    public float dx;
    public float dy;
    public float dz;
    public float i1;
    public float i2;
    public float j1;
    public float j2;
    public float ex;
    public float ey;
    public float ez;
    public float k1;
    public float k2;
    public float l1;
    public float l2;
    public float fx;
    public float fy;
    public float fz;
    public float m1;
    public float m2;
    public float n1;
    public float n2;
    public float gx;
    public float gy;
    public float gz;
    public float o1;
    public float o2;
    public float p1;
    public float p2;
    public float hx;
    public float hy;
    public float hz;
    public float q1;
    public float q2;
    public float r1;
    public float r2;
    public float ix;
    public float iy;
    public float iz;
    public float s1;
    public float s2;
    public float t1;
    public float t2;
    public float jx;
    public float jy;
    public float jz;
    public float u1;
    public float u2;
    public float v1;
    public float v2;
    public float kx;
    public float ky;
    public float kz;
    public float w1;
    public float w2;
    public float x1;
    public float x2;
    public float lx;
    public float ly;
    public float lz;
    public float y1;
    public float y2;
    public float z1;
    public float z2;
    public float mx;
    public float my;
    public float mz;
    public float AA1;
    public float AA2;
    public float BB1;
    public float BB2;
    public float nx;
    public float ny;
    public float nz;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");

        this.gameObject.transform.position = new Vector3(0.0f, 17.5f, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {
        pos1 = player.transform.position.x;
        pos2 = player.transform.position.z;

        if (a1 <= pos1 && pos1 <= a2 && b1 <= pos2 && pos2 <= b2)
        {
            this.gameObject.transform.position = new Vector3(ax, ay, az);

        }
        if (c1 <= pos1 && pos1 <= c2 && d1 <= pos2 && pos2 <= d2)
        {
            this.gameObject.transform.position = new Vector3(bx, by, bz);
        }
        if (e1 <= pos1 && pos1 <= e2 && f1 <= pos2 && pos2 <= f2)
        {
            this.gameObject.transform.position = new Vector3(cx, cy, cz);

        }
        if (g1 <= pos1 && pos1 <= g2 && h1 <= pos2 && pos2 <= h2)
        {
            this.gameObject.transform.position = new Vector3(dx, dy, dz);
        }
        if (i1 <= pos1 && pos1 <= i2 && j1 <= pos2 && pos2 <= j2)
        {
            this.gameObject.transform.position = new Vector3(ex, ey, ez);

        }
        if (k1 <= pos1 && pos1 <= k2 && l1 <= pos2 && pos2 <= l2)
        {
            this.gameObject.transform.position = new Vector3(fx, fy, fz);
        }
        if (m1 <= pos1 && pos1 <= m2 && n1 <= pos2 && pos2 <= n2)
        {
            this.gameObject.transform.position = new Vector3(gx, gy, gz);

        }
        if (o1 <= pos1 && pos1 <= o2 && p1 <= pos2 && pos2 <= p2)
        {
            this.gameObject.transform.position = new Vector3(hx, hy, hz);
        }
        if (q1 <= pos1 && pos1 <= q2 && r1 <= pos2 && pos2 <= r2)
        {
            this.gameObject.transform.position = new Vector3(ix, iy, iz);
        }
        if (s1 <= pos1 && pos1 <= s2 && t1 <= pos2 && pos2 <= t2)
        {
            this.gameObject.transform.position = new Vector3(jx, jy, jz);

        }
        if (u1 <= pos1 && pos1 <= u2 && v1 <= pos2 && pos2 <= v2)
        {
            this.gameObject.transform.position = new Vector3(kx, ky, kz);
        }
        if (w1 <= pos1 && pos1 <= w2 && x1 <= pos2 && pos2 <= x2)
        {
            this.gameObject.transform.position = new Vector3(lx, ly, lz);
        }
        if (y1 <= pos1 && pos1 <= y2 && z1 <= pos2 && pos2 <= z2)
        {
            this.gameObject.transform.position = new Vector3(mx, my, mz);

        }
        if (AA1 <= pos1 && pos1 <= AA2 && BB1 <= pos2 && pos2 <= BB2)
        {
            this.gameObject.transform.position = new Vector3(nx, ny, nz);
        }
    }

}