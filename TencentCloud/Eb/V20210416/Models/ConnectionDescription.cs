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

namespace TencentCloud.Eb.V20210416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConnectionDescription : AbstractModel
    {
        
        /// <summary>
        /// 资源qcs六段式，更多参考 [资源六段式](https://cloud.tencent.com/document/product/598/10606)
        /// </summary>
        [JsonProperty("ResourceDescription")]
        public string ResourceDescription{ get; set; }

        /// <summary>
        /// apigw参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("APIGWParams")]
        public APIGWParams APIGWParams{ get; set; }

        /// <summary>
        /// ckafka参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CkafkaParams")]
        public CkafkaParams CkafkaParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceDescription", this.ResourceDescription);
            this.SetParamObj(map, prefix + "APIGWParams.", this.APIGWParams);
            this.SetParamObj(map, prefix + "CkafkaParams.", this.CkafkaParams);
        }
    }
}

