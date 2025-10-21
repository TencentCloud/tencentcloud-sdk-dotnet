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

    public class AccessKeyUser : AbstractModel
    {
        
        /// <summary>
        /// 账号ID
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// 账号名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 0 主账号 1子账号
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 访问方式
        /// 0 API
        /// 1 控制台与API
        /// </summary>
        [JsonProperty("AccessType")]
        public long? AccessType{ get; set; }

        /// <summary>
        /// 安全建议 枚举 0 正常 1 立即处理 2 建议加固
        /// </summary>
        [JsonProperty("Advice")]
        public long? Advice{ get; set; }

        /// <summary>
        /// 告警信息列表
        /// </summary>
        [JsonProperty("AccessKeyAlarmList")]
        public AccessKeyAlarmInfo[] AccessKeyAlarmList{ get; set; }

        /// <summary>
        /// 风险信息列表
        /// </summary>
        [JsonProperty("AccessKeyRiskList")]
        public AccessKeyAlarmInfo[] AccessKeyRiskList{ get; set; }

        /// <summary>
        /// 账号所属APPID
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// 主账号昵称
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 子账号昵称
        /// </summary>
        [JsonProperty("SubNickname")]
        public string SubNickname{ get; set; }

        /// <summary>
        /// 账号所属主账号Uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 账号自身uin，主账号时与主账号uin一致
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// 登录IP
        /// </summary>
        [JsonProperty("LoginIP")]
        public string LoginIP{ get; set; }

        /// <summary>
        /// 登录地址
        /// </summary>
        [JsonProperty("LoginLocation")]
        public string LoginLocation{ get; set; }

        /// <summary>
        /// 登录时间
        /// </summary>
        [JsonProperty("LoginTime")]
        public string LoginTime{ get; set; }

        /// <summary>
        /// 运营商名称
        /// </summary>
        [JsonProperty("ISP")]
        public string ISP{ get; set; }

        /// <summary>
        /// 操作保护是否开启
        /// 0 未开启
        /// 1 已开启
        /// </summary>
        [JsonProperty("ActionFlag")]
        public long? ActionFlag{ get; set; }

        /// <summary>
        /// 登录保护是否开启
        /// 0 未开启
        /// 1 已开启
        /// </summary>
        [JsonProperty("LoginFlag")]
        public long? LoginFlag{ get; set; }

        /// <summary>
        /// 0 表示已检测 1 表示检测中
        /// </summary>
        [JsonProperty("CheckStatus")]
        public long? CheckStatus{ get; set; }

        /// <summary>
        /// 云厂商类型 0:腾讯云 1:亚马逊云 2:微软云 3:谷歌云 4:阿里云 5:华为云
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "Advice", this.Advice);
            this.SetParamArrayObj(map, prefix + "AccessKeyAlarmList.", this.AccessKeyAlarmList);
            this.SetParamArrayObj(map, prefix + "AccessKeyRiskList.", this.AccessKeyRiskList);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "SubNickname", this.SubNickname);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "LoginIP", this.LoginIP);
            this.SetParamSimple(map, prefix + "LoginLocation", this.LoginLocation);
            this.SetParamSimple(map, prefix + "LoginTime", this.LoginTime);
            this.SetParamSimple(map, prefix + "ISP", this.ISP);
            this.SetParamSimple(map, prefix + "ActionFlag", this.ActionFlag);
            this.SetParamSimple(map, prefix + "LoginFlag", this.LoginFlag);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
        }
    }
}

