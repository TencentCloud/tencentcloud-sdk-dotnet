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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelRouterPackage : AbstractModel
    {
        
        /// <summary>
        /// <p>模型路由资源包总容量</p>
        /// </summary>
        [JsonProperty("CapacitySize")]
        public string CapacitySize{ get; set; }

        /// <summary>
        /// <p>模型路由资源包总余量</p>
        /// </summary>
        [JsonProperty("CapacityRemain")]
        public string CapacityRemain{ get; set; }

        /// <summary>
        /// <p>模型路由资源包容量精确值</p>
        /// </summary>
        [JsonProperty("CapacitySizePrecise")]
        public string CapacitySizePrecise{ get; set; }

        /// <summary>
        /// <p>模型路由资源包总余量精确值</p>
        /// </summary>
        [JsonProperty("CapacityRemainPrecise")]
        public string CapacityRemainPrecise{ get; set; }

        /// <summary>
        /// <p>模型路由资源包设置用尽续购标志位 0:未设置 1:用尽到期新购</p><p>取值范围：[0, 1]</p>
        /// </summary>
        [JsonProperty("AutoPurchaseFlag")]
        public ulong? AutoPurchaseFlag{ get; set; }

        /// <summary>
        /// <p>模型路由资源包Id</p>
        /// </summary>
        [JsonProperty("ModelRouterResourcePackageId")]
        public string ModelRouterResourcePackageId{ get; set; }

        /// <summary>
        /// <p>模型路由资源包创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>模型路由资源包抵扣开始时间</p>
        /// </summary>
        [JsonProperty("DeductionStartTime")]
        public string DeductionStartTime{ get; set; }

        /// <summary>
        /// <p>模型路由资源包抵扣截止时间</p>
        /// </summary>
        [JsonProperty("DeductionEndTime")]
        public string DeductionEndTime{ get; set; }

        /// <summary>
        /// <p>模型路由资源包失效时间</p>
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// <p>模型路由资源包状态</p><p>枚举值：</p><ul><li>0： 有效</li><li>1： 已退款</li><li>2： 已过期</li><li>3： 已用完</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CapacitySize", this.CapacitySize);
            this.SetParamSimple(map, prefix + "CapacityRemain", this.CapacityRemain);
            this.SetParamSimple(map, prefix + "CapacitySizePrecise", this.CapacitySizePrecise);
            this.SetParamSimple(map, prefix + "CapacityRemainPrecise", this.CapacityRemainPrecise);
            this.SetParamSimple(map, prefix + "AutoPurchaseFlag", this.AutoPurchaseFlag);
            this.SetParamSimple(map, prefix + "ModelRouterResourcePackageId", this.ModelRouterResourcePackageId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DeductionStartTime", this.DeductionStartTime);
            this.SetParamSimple(map, prefix + "DeductionEndTime", this.DeductionEndTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

