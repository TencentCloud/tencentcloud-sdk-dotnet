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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddInstanceResult : AbstractModel
    {
        
        /// <summary>
        /// 添加集群失败的节点列表
        /// </summary>
        [JsonProperty("FailedInstanceIds")]
        public string[] FailedInstanceIds{ get; set; }

        /// <summary>
        /// 添加集群成功的节点列表
        /// </summary>
        [JsonProperty("SuccInstanceIds")]
        public string[] SuccInstanceIds{ get; set; }

        /// <summary>
        /// 添加集群超时的节点列表
        /// </summary>
        [JsonProperty("TimeoutInstanceIds")]
        public string[] TimeoutInstanceIds{ get; set; }

        /// <summary>
        /// 失败的节点的失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailedReasons")]
        public string[] FailedReasons{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "FailedInstanceIds.", this.FailedInstanceIds);
            this.SetParamArraySimple(map, prefix + "SuccInstanceIds.", this.SuccInstanceIds);
            this.SetParamArraySimple(map, prefix + "TimeoutInstanceIds.", this.TimeoutInstanceIds);
            this.SetParamArraySimple(map, prefix + "FailedReasons.", this.FailedReasons);
        }
    }
}

