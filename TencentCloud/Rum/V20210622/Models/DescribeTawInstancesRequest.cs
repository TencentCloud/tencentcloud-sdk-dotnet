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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTawInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 计费状态
        /// </summary>
        [JsonProperty("ChargeStatuses")]
        public long?[] ChargeStatuses{ get; set; }

        /// <summary>
        /// 计费类型
        /// </summary>
        [JsonProperty("ChargeTypes")]
        public long?[] ChargeTypes{ get; set; }

        /// <summary>
        /// 分页Limit
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页Offset
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 片区Id
        /// </summary>
        [JsonProperty("AreaIds")]
        public long?[] AreaIds{ get; set; }

        /// <summary>
        /// 实例状态(1=创建中，2=运行中，3=异常，4=重启中，5=停止中，6=已停止，7=销毁中，8=已销毁)
        /// </summary>
        [JsonProperty("InstanceStatuses")]
        public long?[] InstanceStatuses{ get; set; }

        /// <summary>
        /// 实例Id
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 过滤参数
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ChargeStatuses.", this.ChargeStatuses);
            this.SetParamArraySimple(map, prefix + "ChargeTypes.", this.ChargeTypes);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArraySimple(map, prefix + "AreaIds.", this.AreaIds);
            this.SetParamArraySimple(map, prefix + "InstanceStatuses.", this.InstanceStatuses);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

