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

namespace TencentCloud.Eb.V20210416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Transformation : AbstractModel
    {
        
        /// <summary>
        /// 描述如何提取数据，{"ExtractionInputPath":"$.data.payload","Format":"JSON"}
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Extraction")]
        public Extraction Extraction{ get; set; }

        /// <summary>
        /// 描述如何过滤数据;{"Filter":"{\"source\":\"ckafka.cloud.tencent\"}"}
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EtlFilter")]
        public EtlFilter EtlFilter{ get; set; }

        /// <summary>
        /// 描述如何数据转换;"OutputStructs":[{"Key":"op","Value":"$.op","ValueType":"JSONPATH"}]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Transform")]
        public Transform Transform{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Extraction.", this.Extraction);
            this.SetParamObj(map, prefix + "EtlFilter.", this.EtlFilter);
            this.SetParamObj(map, prefix + "Transform.", this.Transform);
        }
    }
}

