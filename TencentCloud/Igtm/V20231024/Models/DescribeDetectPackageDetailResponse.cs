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

namespace TencentCloud.Igtm.V20231024.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDetectPackageDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 资源类型 TASK 探测任务
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 额度
        /// </summary>
        [JsonProperty("Quota")]
        public ulong? Quota{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("CurrentDeadline")]
        public string CurrentDeadline{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 是否过期
        /// </summary>
        [JsonProperty("IsExpire")]
        public ulong? IsExpire{ get; set; }

        /// <summary>
        /// 状态 ENABLED: 正常 ISOLATED: 隔离 DESTROYED：销毁 REFUNDED：已退款
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 是否自动续费：0否1是
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 计费项
        /// </summary>
        [JsonProperty("CostItemList")]
        public CostItem[] CostItemList{ get; set; }

        /// <summary>
        /// 使用数量
        /// </summary>
        [JsonProperty("UsedNum")]
        public ulong? UsedNum{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "Quota", this.Quota);
            this.SetParamSimple(map, prefix + "CurrentDeadline", this.CurrentDeadline);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IsExpire", this.IsExpire);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "CostItemList.", this.CostItemList);
            this.SetParamSimple(map, prefix + "UsedNum", this.UsedNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

