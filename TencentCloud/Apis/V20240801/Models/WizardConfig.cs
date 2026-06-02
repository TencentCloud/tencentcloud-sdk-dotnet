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

namespace TencentCloud.Apis.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WizardConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>表名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbTable")]
        public string DbTable{ get; set; }

        /// <summary>
        /// <p>是否分页</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbEnablePaging")]
        public bool? DbEnablePaging{ get; set; }

        /// <summary>
        /// <p>请求参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbReqParams")]
        public ServiceDatabaseReqParam[] DbReqParams{ get; set; }

        /// <summary>
        /// <p>响应参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbRespParams")]
        public ServiceDatabaseRespParam[] DbRespParams{ get; set; }

        /// <summary>
        /// <p>排序参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbOrdParams")]
        public ServiceDatabaseOrderParam[] DbOrdParams{ get; set; }

        /// <summary>
        /// <p>是否开启出参映射</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbEnableMappingResp")]
        public bool? DbEnableMappingResp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DbTable", this.DbTable);
            this.SetParamSimple(map, prefix + "DbEnablePaging", this.DbEnablePaging);
            this.SetParamArrayObj(map, prefix + "DbReqParams.", this.DbReqParams);
            this.SetParamArrayObj(map, prefix + "DbRespParams.", this.DbRespParams);
            this.SetParamArrayObj(map, prefix + "DbOrdParams.", this.DbOrdParams);
            this.SetParamSimple(map, prefix + "DbEnableMappingResp", this.DbEnableMappingResp);
        }
    }
}

