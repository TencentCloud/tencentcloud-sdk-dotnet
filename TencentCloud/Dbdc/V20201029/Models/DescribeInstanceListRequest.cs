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

namespace TencentCloud.Dbdc.V20201029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceListRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页返回数量
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 排序字段，createTime,instancename两者之一
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 排序规则，desc,asc两者之一
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// 按产品过滤，0:CDB, 1:TDSQL
        /// </summary>
        [JsonProperty("ProductId")]
        public long?[] ProductId{ get; set; }

        /// <summary>
        /// 按实例ID过滤
        /// </summary>
        [JsonProperty("InstanceId")]
        public string[] InstanceId{ get; set; }

        /// <summary>
        /// 按实例名称过滤
        /// </summary>
        [JsonProperty("InstanceName")]
        public string[] InstanceName{ get; set; }

        /// <summary>
        /// 按金融围笼ID过滤
        /// </summary>
        [JsonProperty("FenceId")]
        public string[] FenceId{ get; set; }

        /// <summary>
        /// 按实例状态过滤, -1:已隔离, 0:创建中, 1:运行中, 2:扩容中, 3:删除中
        /// </summary>
        [JsonProperty("Status")]
        public long?[] Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamArraySimple(map, prefix + "ProductId.", this.ProductId);
            this.SetParamArraySimple(map, prefix + "InstanceId.", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "InstanceName.", this.InstanceName);
            this.SetParamArraySimple(map, prefix + "FenceId.", this.FenceId);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
        }
    }
}

