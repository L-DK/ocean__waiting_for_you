using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class L_Problems : MonoBehaviour
{
    #region 公开对象
    public static int val;
    public Text Title;
    public Text Sum;
    public Text OptionA;
    public Text OptionB;
    public Text OptionC;
    public Text OptionD;
    public Text TxtTure;
    public Text GemNumTxt;
    public Image Gem;
    public Image SH;
    public Text SHNumTxt;
    public static int GemNum;
    public static int SHNum;

    #endregion
    public GameObject PanelEnd;
    public GameObject bg;
    public GameObject PanelProblem;
    public static bool isTrue = false;
    public GameObject Role;
    public static int trueNum = 0;
    public Sprite RoleCry;//角色哭泣图片
    public Sprite RoleNo;//正常角色图片
    public Sprite RoleSmile;//微笑角色图片
    public Sprite[] trueAnswer;//正确答案图片数组
    private void Awake()
    {
        PanelEnd.SetActive(false);
        bg.SetActive(false);

        //切换横屏
        Screen.SetResolution(1920, 1080, true);
        Screen.orientation = ScreenOrientation.Landscape;

    }
    void Start()
    {

        Sum.GetComponent<Text>().text = string.Format("第{0}/5题", demo.proLevel);
        val = Random.Range(0, 18);
        Role.GetComponent<SpriteRenderer>().sprite = RoleNo;
        GemNum = Random.Range(5, 9) * trueNum;
        if (demo.proLevel == 6)
        {
            if (L_ImageClick.clickName == "Panel")
            {

                PanelEnd.SetActive(true);
                bg.SetActive(true);

            }

        }
        if (trueNum > 3)
        {
            SHNum = Random.Range(0, 2);
            if (SHNum > 0)
            {
                SH.gameObject.SetActive(true);
                SHNumTxt.gameObject.SetActive(true);
            }
        }
        varDate.money1 += GemNum;
        varDate.money2 += SHNum;
    }

    //1秒后正确答案变红
    void ApperTrueA()
    {
        OptionA.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[0];
        isTrue = true;
    }
    void ApperTrueB()
    {
        OptionB.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[1];
        isTrue = true;
    }
    void ApperTrueC()
    {
        OptionC.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[2];
        isTrue = true;
    }
    void ApperTrueD()
    {
        OptionD.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[3];
        isTrue = true;
    }


    //点击到正确答案 其他答案选项禁止点击
    void CouldClickA()
    {
        OptionB.GetComponent<L_ImageClick>().enabled = false;
        OptionC.GetComponent<L_ImageClick>().enabled = false;
        OptionD.GetComponent<L_ImageClick>().enabled = false;
    }
    void CouldClickB()
    {
        OptionA.GetComponent<L_ImageClick>().enabled = false;
        OptionC.GetComponent<L_ImageClick>().enabled = false;
        OptionD.GetComponent<L_ImageClick>().enabled = false;
    }
    void CouldClickC()
    {
        OptionB.GetComponent<L_ImageClick>().enabled = false;
        OptionA.GetComponent<L_ImageClick>().enabled = false;
        OptionD.GetComponent<L_ImageClick>().enabled = false;
    }
    void CouldClickD()
    {
        OptionB.GetComponent<L_ImageClick>().enabled = false;
        OptionC.GetComponent<L_ImageClick>().enabled = false;
        OptionA.GetComponent<L_ImageClick>().enabled = false;
    }
    void Update()
    {
        TxtTure.GetComponent<Text>().text = string.Format("{0}/5", trueNum);
        GemNumTxt.GetComponent<Text>().text = string.Format("{0}", GemNum);
        SHNumTxt.GetComponent<Text>().text = string.Format("{0}", SHNum);
        if (val == 0)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".下列动物是我国特产的濒临灭绝的爬行动物的是?";
            OptionA.GetComponent<Text>().text = "大鲵";
            OptionB.GetComponent<Text>().text = "扬子鳄";
            OptionC.GetComponent<Text>().text = "中华鲟";
            OptionD.GetComponent<Text>().text = "龟";

            if (L_ImageClick.clickName == "OptionB")
            {
                OptionB.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[1];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                isTrue = true;
                Invoke("CouldClickB", 0f);
            }
            else if (L_ImageClick.clickName == "OptionC" || L_ImageClick.clickName == "OptionB" || L_ImageClick.clickName == "OptionA")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueB", 1f);
            }

        }
        if (val == 1)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".下列哪些物质不会造成对海洋的污染？";
            OptionA.GetComponent<Text>().text = "石油及其产品";
            OptionB.GetComponent<Text>().text = "重金属";
            OptionC.GetComponent<Text>().text = "冰川融化水";
            OptionD.GetComponent<Text>().text = "农药等化学产品";
            if (L_ImageClick.clickName == "OptionC")
            {
                OptionC.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[2];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                isTrue = true;
                Invoke("CouldClickC", 0f);
            }
            else if (L_ImageClick.clickName == "OptionD" || L_ImageClick.clickName == "OptionB" || L_ImageClick.clickName == "OptionA")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueC", 1f);

            }
        }
        if (val == 2)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".陆地上的菊花，秋季开放，而在烟波浩渺的海洋中，却有一年四季盛开不败的“海菊花”，它就是？";
            OptionA.GetComponent<Text>().text = "柳珊瑚";
            OptionB.GetComponent<Text>().text = "马尾藻";
            OptionC.GetComponent<Text>().text = "海葵";
            OptionD.GetComponent<Text>().text = "海星";
            if (L_ImageClick.clickName == "OptionC")
            {
                isTrue = true;
                OptionC.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[2];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                Invoke("CouldClickC", 0f);
            }
            else if (L_ImageClick.clickName == "OptionD" || L_ImageClick.clickName == "OptionB" || L_ImageClick.clickName == "OptionA")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueC", 1f);
            }
        }
        if (val == 3)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".潮汐一天涨落几次？";
            OptionA.GetComponent<Text>().text = "1";
            OptionB.GetComponent<Text>().text = "2";
            OptionC.GetComponent<Text>().text = "3";
            OptionD.GetComponent<Text>().text = "4";
            if (L_ImageClick.clickName == "OptionB")
            {
                isTrue = true;
                OptionB.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[1];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                Invoke("CouldClickB", 0f);
            }
            else if (L_ImageClick.clickName == "OptionC" || L_ImageClick.clickName == "OptionD" || L_ImageClick.clickName == "OptionA")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueB", 1f);
            }
        }
        if (val == 4)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".章鱼有8条腿，乌贼有几条腿？";
            OptionA.GetComponent<Text>().text = "6条";
            OptionB.GetComponent<Text>().text = "8条";
            OptionC.GetComponent<Text>().text = "10条";
            OptionD.GetComponent<Text>().text = "12条";
            if (L_ImageClick.clickName == "OptionC")
            {
                isTrue = true;
                OptionC.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[2];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                Invoke("CouldClickC", 0f);
            }
            else if (L_ImageClick.clickName == "OptionD" || L_ImageClick.clickName == "OptionB" || L_ImageClick.clickName == "OptionA")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueC", 1f);

            }
        }
        if (val == 5)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".号称海洋杀手的是？";
            OptionA.GetComponent<Text>().text = "赤潮";
            OptionB.GetComponent<Text>().text = "潮汐";
            OptionC.GetComponent<Text>().text = "龙卷风";
            OptionD.GetComponent<Text>().text = "海啸";
            if (L_ImageClick.clickName == "OptionD")
            {
                isTrue = true;
                OptionD.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[3];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                Invoke("CouldClickD", 0f);

            }
            else if (L_ImageClick.clickName == "OptionC" || L_ImageClick.clickName == "OptionB" || L_ImageClick.clickName == "OptionA")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueD", 1f);
            }
        }
        if (val == 6)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".下列哪些海洋鱼类是杂食性鱼？";
            OptionA.GetComponent<Text>().text = "带鱼";
            OptionB.GetComponent<Text>().text = "斑鰶";
            OptionC.GetComponent<Text>().text = "梭鱼";
            OptionD.GetComponent<Text>().text = "叶鲹";
            if (L_ImageClick.clickName == "OptionA")
            {
                isTrue = true;
                OptionA.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[0];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                Invoke("CouldClickA", 0f);
            }
            else if (L_ImageClick.clickName == "OptionC" || L_ImageClick.clickName == "OptionB" || L_ImageClick.clickName == "OptionD")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueA", 1f);
            }
        }
        if (val == 7)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".下列的生物中，谁会为了争夺海螺壳打架?";
            OptionA.GetComponent<Text>().text = "海龙虾";
            OptionB.GetComponent<Text>().text = "墨斗鱼";
            OptionC.GetComponent<Text>().text = "寄居蟹";
            OptionD.GetComponent<Text>().text = "无壳螺";
            if (L_ImageClick.clickName == "OptionC")
            {
                isTrue = true;
                OptionC.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[2];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                Invoke("CouldClickC", 0f);
            }
            else if (L_ImageClick.clickName == "OptionD" || L_ImageClick.clickName == "OptionB" || L_ImageClick.clickName == "OptionA")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueC", 1f);
            }
        }
        if (val == 8)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".下列什么海洋生物被称为“海底发电机”?";
            OptionA.GetComponent<Text>().text = "电鳗";
            OptionB.GetComponent<Text>().text = "电鱼";
            OptionC.GetComponent<Text>().text = "电螺";
            OptionD.GetComponent<Text>().text = "电鳐";
            if (L_ImageClick.clickName == "OptionD")
            {

                isTrue = true;
                OptionD.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[3];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                Invoke("CouldClickD", 0f);
            }
            else if (L_ImageClick.clickName == "OptionC" || L_ImageClick.clickName == "OptionB" || L_ImageClick.clickName == "OptionA")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueD", 1f);
            }
        }
        if (val == 9)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".下列什么鱼的眼睛长在身体同- -侧?";
            OptionA.GetComponent<Text>().text = "鲨鱼";
            OptionB.GetComponent<Text>().text = "电鳗";
            OptionC.GetComponent<Text>().text = "小丑鱼";
            OptionD.GetComponent<Text>().text = "比目鱼";
            if (L_ImageClick.clickName == "OptionD")
            {
                isTrue = true;
                OptionD.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[3];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                Invoke("CouldClickD", 0f);
            }
            else if (L_ImageClick.clickName == "OptionC" || L_ImageClick.clickName == "OptionB" || L_ImageClick.clickName == "OptionA")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueD", 1f);
            }
        }
        if (val == 10)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".下列哪种海洋生物中，是由雄性负责育儿的?";
            OptionA.GetComponent<Text>().text = "海马";
            OptionB.GetComponent<Text>().text = "海牛";
            OptionC.GetComponent<Text>().text = "海狮鼠";
            OptionD.GetComponent<Text>().text = "海豹狸";
            if (L_ImageClick.clickName == "OptionA")
            {
                isTrue = true;
                OptionA.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[0];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                Invoke("CouldClickA", 0f);
            }
            else if (L_ImageClick.clickName == "OptionC" || L_ImageClick.clickName == "OptionB" || L_ImageClick.clickName == "OptionD")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueA", 1f);
            }
        }
        if (val == 11)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".目前医学研究中认为某些海洋生物体内存在能抑制和逆转癌的物质，下列哪种生物最可能具有这种特性?";
            OptionA.GetComponent<Text>().text = "海龟";
            OptionB.GetComponent<Text>().text = "海豹";
            OptionC.GetComponent<Text>().text = "鲨鱼";
            OptionD.GetComponent<Text>().text = "海豚";
            if (L_ImageClick.clickName == "OptionC")
            {
                isTrue = true;
                OptionC.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[2];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                Invoke("CouldClickC", 0f);
            }
            else if (L_ImageClick.clickName == "OptionD" || L_ImageClick.clickName == "OptionB" || L_ImageClick.clickName == "OptionA")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueC", 1f);
            }
        }
        if (val == 12)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".海蛇的天敌是什么?";
            OptionA.GetComponent<Text>().text = "海鹰";
            OptionB.GetComponent<Text>().text = "鳗尾鲶";
            OptionC.GetComponent<Text>().text = "水母";
            OptionD.GetComponent<Text>().text = "海葵";
            if (L_ImageClick.clickName == "OptionA")
            {
                isTrue = true;
                OptionA.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[0];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                Invoke("CouldClickA", 0f);
            }
            else if (L_ImageClick.clickName == "OptionC" || L_ImageClick.clickName == "OptionB" || L_ImageClick.clickName == "OptionD")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueA", 1f);
            }
        }
        if (val == 13)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".目前世界上结构最简单的多细胞动物是什么?";
            OptionA.GetComponent<Text>().text = "珊瑚虫";
            OptionB.GetComponent<Text>().text = "海绵";
            OptionC.GetComponent<Text>().text = "鹦鹉螺";
            OptionD.GetComponent<Text>().text = "菊石";
            if (L_ImageClick.clickName == "OptionB")
            {
                isTrue = true;
                OptionB.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[1];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                Invoke("CouldClickB", 0f);
            }
            else if (L_ImageClick.clickName == "OptionC" || L_ImageClick.clickName == "OptionD" || L_ImageClick.clickName == "OptionA")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueB", 1f);
            }
        }
        if (val == 14)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".世界上唯一能够在海中生活的蛙叫做什么?";
            OptionA.GetComponent<Text>().text = "箭毒蛙";
            OptionB.GetComponent<Text>().text = "食蟹蛙";
            OptionC.GetComponent<Text>().text = "飞树蛙";
            OptionD.GetComponent<Text>().text = "虎纹蛙";
            if (L_ImageClick.clickName == "OptionB")
            {
                isTrue = true;
                OptionB.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[1];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                Invoke("CouldClickB", 0f);
            }
            else if (L_ImageClick.clickName == "OptionC" || L_ImageClick.clickName == "OptionD" || L_ImageClick.clickName == "OptionA")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueB", 1f);
            }
        }
        if (val == 15)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".下列哪种生物是海马的亲戚?";
            OptionA.GetComponent<Text>().text = "海龙";
            OptionB.GetComponent<Text>().text = "海牛";
            OptionC.GetComponent<Text>().text = "海龟";
            OptionD.GetComponent<Text>().text = "海狗";
            if (L_ImageClick.clickName == "OptionA")
            {
                isTrue = true;
                OptionA.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[0];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                Invoke("CouldClickA", 0f);
            }
            else if (L_ImageClick.clickName == "OptionC" || L_ImageClick.clickName == "OptionB" || L_ImageClick.clickName == "OptionD")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueA", 1f);
            }
        }
        if (val == 16)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".海洋里寿命最长的动物是?";
            OptionA.GetComponent<Text>().text = "鲨鱼";
            OptionB.GetComponent<Text>().text = "海豚";
            OptionC.GetComponent<Text>().text = "海龟";
            OptionD.GetComponent<Text>().text = "海象";
            if (L_ImageClick.clickName == "OptionD")
            {
                isTrue = true;
                OptionD.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[3];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                Invoke("CouldClickD", 0f);
            }
            else if (L_ImageClick.clickName == "OptionC" || L_ImageClick.clickName == "OptionB" || L_ImageClick.clickName == "OptionA")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueD", 1f);
            }
        }
        if (val == 17)
        {
            Title.GetComponent<Text>().text = demo.proLevel + ".有“海中霸王”这称的是?";
            OptionA.GetComponent<Text>().text = "海狮";
            OptionB.GetComponent<Text>().text = "海象";
            OptionC.GetComponent<Text>().text = "鲨鱼";
            OptionD.GetComponent<Text>().text = "海牛";
            if (L_ImageClick.clickName == "OptionD")
            {
                isTrue = true;
                OptionD.transform.GetChild(0).GetComponent<Image>().sprite = trueAnswer[3];
                Role.GetComponent<SpriteRenderer>().sprite = RoleSmile;
                Invoke("CouldClickD", 0f);
            }
            else if (L_ImageClick.clickName == "OptionC" || L_ImageClick.clickName == "OptionB" || L_ImageClick.clickName == "OptionA")
            {
                Role.GetComponent<SpriteRenderer>().sprite = RoleCry;
                Invoke("ApperTrueD", 1f);
            }
        }
        if (demo.proLevel >= 6)
        {
            isTrue = false;
            if (L_ImageClick.clickName == "Panel")
            {
                PanelProblem.SetActive(false);
            }


            Sum.GetComponent<Text>().text = string.Format("第{0}/5题", demo.proLevel);


        }
        if (GemNum > 0)
        {
            Gem.gameObject.SetActive(true);
        }

    }
}
