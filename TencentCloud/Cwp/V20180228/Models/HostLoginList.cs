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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostLoginList : AbstractModel
    {
        
        /// <summary>
        /// <p>记录Id</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>主机Uuid</p>
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// <p>主机ip</p>
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// <p>主机名</p>
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// <p>用户名</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>来源ip</p>
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// <p>1:正常登录；2异地登录； 5已加白； 14：已处理；15：已忽略。</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>国家id</p>
        /// </summary>
        [JsonProperty("Country")]
        public ulong? Country{ get; set; }

        /// <summary>
        /// <p>城市id</p>
        /// </summary>
        [JsonProperty("City")]
        public ulong? City{ get; set; }

        /// <summary>
        /// <p>省份id</p>
        /// </summary>
        [JsonProperty("Province")]
        public ulong? Province{ get; set; }

        /// <summary>
        /// <p>登录时间</p>
        /// </summary>
        [JsonProperty("LoginTime")]
        public string LoginTime{ get; set; }

        /// <summary>
        /// <p>修改时间</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>是否命中异地登录异常  1表示命中此类异常, 0表示未命中</p>
        /// </summary>
        [JsonProperty("IsRiskArea")]
        public ulong? IsRiskArea{ get; set; }

        /// <summary>
        /// <p>是否命中异常用户异常 1表示命中此类异常, 0表示未命中</p>
        /// </summary>
        [JsonProperty("IsRiskUser")]
        public ulong? IsRiskUser{ get; set; }

        /// <summary>
        /// <p>是否命中异常时间异常 1表示命中此类异常, 0表示未命中</p>
        /// </summary>
        [JsonProperty("IsRiskTime")]
        public ulong? IsRiskTime{ get; set; }

        /// <summary>
        /// <p>是否命中异常IP异常 1表示命中此类异常, 0表示未命中</p>
        /// </summary>
        [JsonProperty("IsRiskSrcIp")]
        public ulong? IsRiskSrcIp{ get; set; }

        /// <summary>
        /// <p>危险等级：<br>0 高危<br>1 可疑</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public ulong? RiskLevel{ get; set; }

        /// <summary>
        /// <p>位置名称</p>
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// <p>主机quuid</p>
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// <p>高危信息说明：<br>ABROAD - 境外IP；<br>XTI - 威胁情报</p>
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// <p>附加信息</p>
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }

        /// <summary>
        /// <p>请求目的端口</p>
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// <p>ip分析</p>
        /// </summary>
        [JsonProperty("IPAnalyse")]
        public IPAnalyse IPAnalyse{ get; set; }

        /// <summary>
        /// <p>命中策略ID</p><p>枚举值：</p><ul><li>risk_login_1： 威胁情报</li><li>risk_login_2： 密码破解成功后登录</li><li>risk_login_3： 弱口令账户登录</li><li>risk_login_4： 非法账户登录</li><li>risk_login_5： 登录后存在入侵行为</li><li>risk_login_101： 海外IP登录</li><li>risk_login_102： 非常用登录地登录</li><li>risk_login_103： 非工作时间登录</li></ul>
        /// </summary>
        [JsonProperty("HitRule")]
        public string HitRule{ get; set; }

        /// <summary>
        /// <p>命中策略名</p>
        /// </summary>
        [JsonProperty("HitRuleName")]
        public string HitRuleName{ get; set; }

        /// <summary>
        /// <p>告警数量</p>
        /// </summary>
        [JsonProperty("AlertCount")]
        public long? AlertCount{ get; set; }

        /// <summary>
        /// <p>首次发现时间</p><p>参数格式：YYYY-MM-DD HH:MM:SS</p>
        /// </summary>
        [JsonProperty("FirstDiscoverTime")]
        public string FirstDiscoverTime{ get; set; }

        /// <summary>
        /// <p>最近发现时间</p><p>参数格式：YYYY-MM-DD HH:MM:SS</p>
        /// </summary>
        [JsonProperty("LastDiscoverTime")]
        public string LastDiscoverTime{ get; set; }

        /// <summary>
        /// <p>危害描述</p>
        /// </summary>
        [JsonProperty("HarmDescribe")]
        public string HarmDescribe{ get; set; }

        /// <summary>
        /// <p>修复建议</p>
        /// </summary>
        [JsonProperty("SuggestScheme")]
        public string SuggestScheme{ get; set; }

        /// <summary>
        /// <p>最近登录历史</p>
        /// </summary>
        [JsonProperty("RecentLoginList")]
        public RecentLoginItem[] RecentLoginList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "LoginTime", this.LoginTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "IsRiskArea", this.IsRiskArea);
            this.SetParamSimple(map, prefix + "IsRiskUser", this.IsRiskUser);
            this.SetParamSimple(map, prefix + "IsRiskTime", this.IsRiskTime);
            this.SetParamSimple(map, prefix + "IsRiskSrcIp", this.IsRiskSrcIp);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamObj(map, prefix + "IPAnalyse.", this.IPAnalyse);
            this.SetParamSimple(map, prefix + "HitRule", this.HitRule);
            this.SetParamSimple(map, prefix + "HitRuleName", this.HitRuleName);
            this.SetParamSimple(map, prefix + "AlertCount", this.AlertCount);
            this.SetParamSimple(map, prefix + "FirstDiscoverTime", this.FirstDiscoverTime);
            this.SetParamSimple(map, prefix + "LastDiscoverTime", this.LastDiscoverTime);
            this.SetParamSimple(map, prefix + "HarmDescribe", this.HarmDescribe);
            this.SetParamSimple(map, prefix + "SuggestScheme", this.SuggestScheme);
            this.SetParamArrayObj(map, prefix + "RecentLoginList.", this.RecentLoginList);
        }
    }
}

