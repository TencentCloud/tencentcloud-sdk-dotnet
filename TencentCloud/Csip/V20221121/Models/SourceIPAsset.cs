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

    public class SourceIPAsset : AbstractModel
    {
        
        /// <summary>
        /// 源IP id
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// 源IP
        /// </summary>
        [JsonProperty("SourceIP")]
        public string SourceIP{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 账号所属APPID
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// IP地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 调用方式
        /// 0:控制台调用
        /// 1:API
        /// </summary>
        [JsonProperty("EventType")]
        public long? EventType{ get; set; }

        /// <summary>
        /// IP类型
        /// 0:账号内（未备注）
        /// 1:账号外（未备注）
        /// 2:账号内   (已备注)
        /// 3:账号外   (已备注)
        /// </summary>
        [JsonProperty("IPType")]
        public long? IPType{ get; set; }

        /// <summary>
        /// 告警信息列表
        /// </summary>
        [JsonProperty("AccessKeyAlarmList")]
        public AccessKeyAlarmInfo[] AccessKeyAlarmList{ get; set; }

        /// <summary>
        /// ak信息列表
        /// </summary>
        [JsonProperty("AKInfo")]
        public AKInfo[] AKInfo{ get; set; }

        /// <summary>
        /// 调用接口数量
        /// </summary>
        [JsonProperty("ActionCount")]
        public long? ActionCount{ get; set; }

        /// <summary>
        /// 最近访问时间
        /// </summary>
        [JsonProperty("LastAccessTime")]
        public string LastAccessTime{ get; set; }

        /// <summary>
        /// IP关联实例ID，如果为空字符串，代表非账号内资产
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// IP关联实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 账号所属Uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 展示状态
        /// </summary>
        [JsonProperty("ShowStatus")]
        public bool? ShowStatus{ get; set; }

        /// <summary>
        /// 运营商字段
        /// </summary>
        [JsonProperty("ISP")]
        public string ISP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "SourceIP", this.SourceIP);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "IPType", this.IPType);
            this.SetParamArrayObj(map, prefix + "AccessKeyAlarmList.", this.AccessKeyAlarmList);
            this.SetParamArrayObj(map, prefix + "AKInfo.", this.AKInfo);
            this.SetParamSimple(map, prefix + "ActionCount", this.ActionCount);
            this.SetParamSimple(map, prefix + "LastAccessTime", this.LastAccessTime);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "ShowStatus", this.ShowStatus);
            this.SetParamSimple(map, prefix + "ISP", this.ISP);
        }
    }
}

