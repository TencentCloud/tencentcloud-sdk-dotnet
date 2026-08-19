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

    public class CloudFunctionItem : AbstractModel
    {
        
        /// <summary>
        /// 云函数名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 云函数状态
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// 云函数类型
        /// </summary>
        [JsonProperty("FunctionType")]
        public string FunctionType{ get; set; }

        /// <summary>
        /// 资源标签
        /// </summary>
        [JsonProperty("InstanceTag")]
        public string InstanceTag{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 自定义域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 实例类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// 云函数状态展示内容
        /// </summary>
        [JsonProperty("InstanceStatusDisplay")]
        public string InstanceStatusDisplay{ get; set; }

        /// <summary>
        /// 核心资产标签
        /// </summary>
        [JsonProperty("CoreAssetFlag")]
        public string CoreAssetFlag{ get; set; }

        /// <summary>
        /// 公网访问URL
        /// </summary>
        [JsonProperty("PublicURL")]
        public string PublicURL{ get; set; }

        /// <summary>
        /// 私网访问URL
        /// </summary>
        [JsonProperty("PrivateURL")]
        public string PrivateURL{ get; set; }

        /// <summary>
        /// 所属账号
        /// </summary>
        [JsonProperty("AccountInfo")]
        public string AccountInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "FunctionType", this.FunctionType);
            this.SetParamSimple(map, prefix + "InstanceTag", this.InstanceTag);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "InstanceStatusDisplay", this.InstanceStatusDisplay);
            this.SetParamSimple(map, prefix + "CoreAssetFlag", this.CoreAssetFlag);
            this.SetParamSimple(map, prefix + "PublicURL", this.PublicURL);
            this.SetParamSimple(map, prefix + "PrivateURL", this.PrivateURL);
            this.SetParamSimple(map, prefix + "AccountInfo", this.AccountInfo);
        }
    }
}

