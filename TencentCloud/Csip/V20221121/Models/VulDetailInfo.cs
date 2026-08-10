/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>漏洞ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>漏洞名字</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>CveID</p>
        /// </summary>
        [JsonProperty("CVEID")]
        public string CVEID{ get; set; }

        /// <summary>
        /// 漏洞分类
        /// 枚举值：
        /// LINUX：Linux 软件漏洞
        /// WINDOWS：Windows 系统补丁
        /// WEB_CMS：Web-CMS 漏洞
        /// APPLICATION：应用漏洞
        /// EMERGENCY：应急漏洞
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 漏洞披露时间
        /// 参数格式：YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// <p>检测方式</p><p>枚举值：</p><ul><li>VersionCompare： 版本对比</li><li>POC： POC检测</li></ul>
        /// </summary>
        [JsonProperty("CheckMethod")]
        public string CheckMethod{ get; set; }

        /// <summary>
        /// 漏洞防御状态
        /// 枚举值：
        /// ENABLED：已开启
        /// NOT_SUPPORTED：不支持
        /// NOT_ENABLED：未开启
        /// </summary>
        [JsonProperty("DefendStatus")]
        public string DefendStatus{ get; set; }

        /// <summary>
        /// 是否支持一键修复
        /// 枚举值：
        /// true：支持
        /// false：不支持
        /// </summary>
        [JsonProperty("SupportFix")]
        public bool? SupportFix{ get; set; }

        /// <summary>
        /// VPR 评级信息（包含评级结果、说明和分阶段评分）
        /// </summary>
        [JsonProperty("VRPRatingInfo")]
        public VPRRatingInfo VRPRatingInfo{ get; set; }

        /// <summary>
        /// CVSS 评分
        /// 取值范围：[0.0, 10.0]
        /// </summary>
        [JsonProperty("CvssScore")]
        public float? CvssScore{ get; set; }

        /// <summary>
        /// VPR 风险标签列表（如在野利用、有 EXP、有 POC、外网暴露、无需重启等）
        /// </summary>
        [JsonProperty("Label")]
        public VPRLabel[] Label{ get; set; }

        /// <summary>
        /// 漏洞备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 漏洞概述说明
        /// </summary>
        [JsonProperty("Summary")]
        public string Summary{ get; set; }

        /// <summary>
        /// 已开启漏洞防御的主机数
        /// </summary>
        [JsonProperty("DefendHostCount")]
        public ulong? DefendHostCount{ get; set; }

        /// <summary>
        /// 未开启漏洞防御的主机数
        /// </summary>
        [JsonProperty("NotDefendHostCount")]
        public ulong? NotDefendHostCount{ get; set; }

        /// <summary>
        /// 最近扫描时间
        /// 参数格式：YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// CVSS 危害等级
        /// 枚举值：
        /// INVALID：无效
        /// INFO：提示
        /// LOW：低危
        /// MEDIUM：中危
        /// HIGH：高危
        /// CRITICAL：严重
        /// </summary>
        [JsonProperty("CVSSLevel")]
        public string CVSSLevel{ get; set; }

        /// <summary>
        /// 受影响软件描述列表（每项形如 openssl < 1.1.1k）
        /// </summary>
        [JsonProperty("VulAffect")]
        public string[] VulAffect{ get; set; }

        /// <summary>
        /// 是否被 KVE（已知被利用漏洞）库收录
        /// 枚举值：
        /// true：已收录
        /// false：未收录
        /// </summary>
        [JsonProperty("KVERecord")]
        public bool? KVERecord{ get; set; }

        /// <summary>
        /// KVE 收录时间
        /// 参数格式：YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("KVERecordTime")]
        public string KVERecordTime{ get; set; }

        /// <summary>
        /// EPSS 评分（漏洞利用概率预测）
        /// 取值范围：[0.0, 1.0]
        /// </summary>
        [JsonProperty("EPSSScore")]
        public float? EPSSScore{ get; set; }

        /// <summary>
        /// 受影响厂商列表
        /// </summary>
        [JsonProperty("AffectVendor")]
        public string[] AffectVendor{ get; set; }

        /// <summary>
        /// 受影响产品列表
        /// </summary>
        [JsonProperty("AffectProduct")]
        public string[] AffectProduct{ get; set; }

        /// <summary>
        /// 漏洞利用机制说明
        /// </summary>
        [JsonProperty("Mechanism")]
        public string Mechanism{ get; set; }

        /// <summary>
        /// 漏洞利用前置条件说明
        /// </summary>
        [JsonProperty("Precondition")]
        public string Precondition{ get; set; }

        /// <summary>
        /// 漏洞最新传播趋势数据列表（按日期）
        /// </summary>
        [JsonProperty("LatestTrend")]
        public VulSpreadTrend[] LatestTrend{ get; set; }

        /// <summary>
        /// <p>修复方案</p>
        /// </summary>
        [JsonProperty("FixSolution")]
        public string FixSolution{ get; set; }

        /// <summary>
        /// <p>参考链接</p>
        /// </summary>
        [JsonProperty("RefLink")]
        public string RefLink{ get; set; }

        /// <summary>
        /// <p>漏洞危害描述</p>
        /// </summary>
        [JsonProperty("HarmDescription")]
        public string HarmDescription{ get; set; }

        /// <summary>
        /// <p>漏洞影响产品</p>
        /// </summary>
        [JsonProperty("AffectVendorProduct")]
        public VulVendorProduct[] AffectVendorProduct{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CVEID", this.CVEID);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "CheckMethod", this.CheckMethod);
            this.SetParamSimple(map, prefix + "DefendStatus", this.DefendStatus);
            this.SetParamSimple(map, prefix + "SupportFix", this.SupportFix);
            this.SetParamObj(map, prefix + "VRPRatingInfo.", this.VRPRatingInfo);
            this.SetParamSimple(map, prefix + "CvssScore", this.CvssScore);
            this.SetParamArrayObj(map, prefix + "Label.", this.Label);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Summary", this.Summary);
            this.SetParamSimple(map, prefix + "DefendHostCount", this.DefendHostCount);
            this.SetParamSimple(map, prefix + "NotDefendHostCount", this.NotDefendHostCount);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamSimple(map, prefix + "CVSSLevel", this.CVSSLevel);
            this.SetParamArraySimple(map, prefix + "VulAffect.", this.VulAffect);
            this.SetParamSimple(map, prefix + "KVERecord", this.KVERecord);
            this.SetParamSimple(map, prefix + "KVERecordTime", this.KVERecordTime);
            this.SetParamSimple(map, prefix + "EPSSScore", this.EPSSScore);
            this.SetParamArraySimple(map, prefix + "AffectVendor.", this.AffectVendor);
            this.SetParamArraySimple(map, prefix + "AffectProduct.", this.AffectProduct);
            this.SetParamSimple(map, prefix + "Mechanism", this.Mechanism);
            this.SetParamSimple(map, prefix + "Precondition", this.Precondition);
            this.SetParamArrayObj(map, prefix + "LatestTrend.", this.LatestTrend);
            this.SetParamSimple(map, prefix + "FixSolution", this.FixSolution);
            this.SetParamSimple(map, prefix + "RefLink", this.RefLink);
            this.SetParamSimple(map, prefix + "HarmDescription", this.HarmDescription);
            this.SetParamArrayObj(map, prefix + "AffectVendorProduct.", this.AffectVendorProduct);
        }
    }
}

