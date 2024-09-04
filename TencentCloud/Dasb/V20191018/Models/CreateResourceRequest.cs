/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Dasb.V20191018.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateResourceRequest : AbstractModel
    {
        
        /// <summary>
        /// 部署region
        /// </summary>
        [JsonProperty("DeployRegion")]
        public string DeployRegion{ get; set; }

        /// <summary>
        /// 部署堡垒机的VpcId
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 部署堡垒机的SubnetId
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 资源类型。取值:standard/pro
        /// </summary>
        [JsonProperty("ResourceEdition")]
        public string ResourceEdition{ get; set; }

        /// <summary>
        /// 资源节点数
        /// </summary>
        [JsonProperty("ResourceNode")]
        public long? ResourceNode{ get; set; }

        /// <summary>
        /// 计费周期
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 计费时长
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// 计费模式 1预付费
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 自动续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 部署zone
        /// </summary>
        [JsonProperty("DeployZone")]
        public string DeployZone{ get; set; }

        /// <summary>
        /// 0非试用版，1试用版
        /// </summary>
        [JsonProperty("Trial")]
        public ulong? Trial{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeployRegion", this.DeployRegion);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ResourceEdition", this.ResourceEdition);
            this.SetParamSimple(map, prefix + "ResourceNode", this.ResourceNode);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "DeployZone", this.DeployZone);
            this.SetParamSimple(map, prefix + "Trial", this.Trial);
        }
    }
}

