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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOrderInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 每页展示数量
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 按某个字段排序，目前仅支持CreateTime排序。
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 升序（asc）还是降序（desc），默认：desc。
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }

        /// <summary>
        /// （条件过滤字段）平台类型  1.android加固   2.ios源码混淆  3.sdk加固  4.applet小程序加固
        /// </summary>
        [JsonProperty("PlatformType")]
        public long? PlatformType{ get; set; }

        /// <summary>
        /// （条件过滤字段）订单采购类型 1-免费试用 2-按年收费 3-按次收费
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// （条件过滤字段）订单审批状态：
        /// </summary>
        [JsonProperty("ApprovalStatus")]
        public long? ApprovalStatus{ get; set; }

        /// <summary>
        /// （条件过滤字段）资源状态：
        /// </summary>
        [JsonProperty("ResourceStatus")]
        public long? ResourceStatus{ get; set; }

        /// <summary>
        /// （条件过滤字段）订单ID
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// （条件过滤字段）资源ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// （条件过滤字段）包名，查询android加固订单时使用
        /// </summary>
        [JsonProperty("AppPkgName")]
        public string AppPkgName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
            this.SetParamSimple(map, prefix + "PlatformType", this.PlatformType);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "ApprovalStatus", this.ApprovalStatus);
            this.SetParamSimple(map, prefix + "ResourceStatus", this.ResourceStatus);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "AppPkgName", this.AppPkgName);
        }
    }
}

