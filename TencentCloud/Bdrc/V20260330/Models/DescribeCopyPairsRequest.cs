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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCopyPairsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>要查询复制对的类型，可选值：DISK、INSTANCE、CFS</p>
        /// </summary>
        [JsonProperty("CopyPairType")]
        public string CopyPairType{ get; set; }

        /// <summary>
        /// <p>要查询复制对ID列表</p>
        /// </summary>
        [JsonProperty("CopyPairIds")]
        public string[] CopyPairIds{ get; set; }

        /// <summary>
        /// <p>过滤条件，详见过滤条件表。支持的Name：disaster-recovery-site-pair-id、target-resource-id、source-resource-id、copy-pair-id、copy-pair-name</p>
        /// </summary>
        [JsonProperty("Filters")]
        public FilterModel[] Filters{ get; set; }

        /// <summary>
        /// <p>偏移量，默认为0。关于Offset的更进一步介绍请参考 API 简介中的相关小节</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>返回数量，默认为20，最大值为100。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>输出结果按升序还是降序，可选值：ASC、DESC</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>输出结果的排序字段，可选值：CREATE_TIME</p>
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// <p>是否要查询保护时间点列表，默认 false。当设置为 true 时，必须同时传入 CopyPairIds 参数。</p>
        /// </summary>
        [JsonProperty("QueryProtectionTime")]
        public bool? QueryProtectionTime{ get; set; }

        /// <summary>
        /// <p>是否查询跨云+非跨云全部复制对，默认 false</p>
        /// </summary>
        [JsonProperty("GetAllCopyPair")]
        public bool? GetAllCopyPair{ get; set; }

        /// <summary>
        /// <p>是否要查询 CVM 创建参数（仅对延迟创建模式且目标 CVM 未创建的复制对生效），默认为true。为 true 时，每条 deferred_create=1 AND target_cvm_created=0 的 CVM 复制对出参会附带 CvmCreateParams 字段</p>
        /// </summary>
        [JsonProperty("QueryCvmCreateParams")]
        public bool? QueryCvmCreateParams{ get; set; }

        /// <summary>
        /// <p>复制对创建来源过滤。不传则查询所有；传 LOCAL 仅查本端创建的复制对，传 PEER 仅查对端创建的复制对。</p><p>枚举值：</p><ul><li>LOCAL： 仅查本端创建的复制对</li><li>PEER： 仅查对端创建的复制对</li></ul>
        /// </summary>
        [JsonProperty("CreateFrom")]
        public string CreateFrom{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CopyPairType", this.CopyPairType);
            this.SetParamArraySimple(map, prefix + "CopyPairIds.", this.CopyPairIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "QueryProtectionTime", this.QueryProtectionTime);
            this.SetParamSimple(map, prefix + "GetAllCopyPair", this.GetAllCopyPair);
            this.SetParamSimple(map, prefix + "QueryCvmCreateParams", this.QueryCvmCreateParams);
            this.SetParamSimple(map, prefix + "CreateFrom", this.CreateFrom);
        }
    }
}

