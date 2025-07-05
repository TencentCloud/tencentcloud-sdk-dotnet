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

    public class AssetViewWeakPassRisk : AbstractModel
    {
        
        /// <summary>
        /// 影响资产
        /// </summary>
        [JsonProperty("AffectAsset")]
        public string AffectAsset{ get; set; }

        /// <summary>
        /// 风险等级，low-低危，high-高危，middle-中危，info-提示，extreme-严重。
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 组件
        /// </summary>
        [JsonProperty("Component")]
        public string Component{ get; set; }

        /// <summary>
        /// 服务
        /// </summary>
        [JsonProperty("Service")]
        public string Service{ get; set; }

        /// <summary>
        /// 最近识别时间
        /// </summary>
        [JsonProperty("RecentTime")]
        public string RecentTime{ get; set; }

        /// <summary>
        /// 首次识别时间
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// 状态，0未处理、1已处置、2已忽略
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// ID，处理风险使用
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 前端索引
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 用户appid
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("Nick")]
        public string Nick{ get; set; }

        /// <summary>
        /// 用户uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 弱口令类型
        /// </summary>
        [JsonProperty("PasswordType")]
        public string PasswordType{ get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// 漏洞类型
        /// </summary>
        [JsonProperty("VULType")]
        public string VULType{ get; set; }

        /// <summary>
        /// 漏洞url
        /// </summary>
        [JsonProperty("VULURL")]
        public string VULURL{ get; set; }

        /// <summary>
        /// 修复建议
        /// </summary>
        [JsonProperty("Fix")]
        public string Fix{ get; set; }

        /// <summary>
        /// 证明
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AffectAsset", this.AffectAsset);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Component", this.Component);
            this.SetParamSimple(map, prefix + "Service", this.Service);
            this.SetParamSimple(map, prefix + "RecentTime", this.RecentTime);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Nick", this.Nick);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "PasswordType", this.PasswordType);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "VULType", this.VULType);
            this.SetParamSimple(map, prefix + "VULURL", this.VULURL);
            this.SetParamSimple(map, prefix + "Fix", this.Fix);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "Port", this.Port);
        }
    }
}

