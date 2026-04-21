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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAllocateConditionsResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>产品筛选列表</p>
        /// </summary>
        [JsonProperty("Business")]
        public BillBusinessLink[] Business{ get; set; }

        /// <summary>
        /// <p>子产品筛选列表</p>
        /// </summary>
        [JsonProperty("Product")]
        public BillProduct[] Product{ get; set; }

        /// <summary>
        /// <p>组件名称筛选列表</p>
        /// </summary>
        [JsonProperty("Item")]
        public BillItem[] Item{ get; set; }

        /// <summary>
        /// <p>地域筛选列表</p>
        /// </summary>
        [JsonProperty("Region")]
        public BillRegion[] Region{ get; set; }

        /// <summary>
        /// <p>实例类型筛选列表</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public BillInstanceType[] InstanceType{ get; set; }

        /// <summary>
        /// <p>计费模式筛选列表</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public BillPayMode[] PayMode{ get; set; }

        /// <summary>
        /// <p>项目筛选列表</p>
        /// </summary>
        [JsonProperty("Project")]
        public BillProject[] Project{ get; set; }

        /// <summary>
        /// <p>标签筛选列表</p>
        /// </summary>
        [JsonProperty("Tag")]
        public BillTag[] Tag{ get; set; }

        /// <summary>
        /// <p>使用者 UIN 筛选列表</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public BillOwnerUin[] OwnerUin{ get; set; }

        /// <summary>
        /// <p>操作者 UIN 筛选列表</p>
        /// </summary>
        [JsonProperty("OperateUin")]
        public BillOperateUin[] OperateUin{ get; set; }

        /// <summary>
        /// <p>交易类型筛选列表</p>
        /// </summary>
        [JsonProperty("ActionType")]
        public BillActionType[] ActionType{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Business.", this.Business);
            this.SetParamArrayObj(map, prefix + "Product.", this.Product);
            this.SetParamArrayObj(map, prefix + "Item.", this.Item);
            this.SetParamArrayObj(map, prefix + "Region.", this.Region);
            this.SetParamArrayObj(map, prefix + "InstanceType.", this.InstanceType);
            this.SetParamArrayObj(map, prefix + "PayMode.", this.PayMode);
            this.SetParamArrayObj(map, prefix + "Project.", this.Project);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamArrayObj(map, prefix + "OwnerUin.", this.OwnerUin);
            this.SetParamArrayObj(map, prefix + "OperateUin.", this.OperateUin);
            this.SetParamArrayObj(map, prefix + "ActionType.", this.ActionType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

