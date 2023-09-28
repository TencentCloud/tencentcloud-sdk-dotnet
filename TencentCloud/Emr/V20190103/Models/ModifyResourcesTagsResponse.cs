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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyResourcesTagsResponse : AbstractModel
    {
        
        /// <summary>
        /// 成功的资源id列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessList")]
        public string[] SuccessList{ get; set; }

        /// <summary>
        /// 失败的资源id列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailList")]
        public string[] FailList{ get; set; }

        /// <summary>
        /// 部分成功的资源id列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PartSuccessList")]
        public string[] PartSuccessList{ get; set; }

        /// <summary>
        /// 集群id与流程id的映射列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterToFlowIdList")]
        public ClusterIDToFlowID[] ClusterToFlowIdList{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SuccessList.", this.SuccessList);
            this.SetParamArraySimple(map, prefix + "FailList.", this.FailList);
            this.SetParamArraySimple(map, prefix + "PartSuccessList.", this.PartSuccessList);
            this.SetParamArrayObj(map, prefix + "ClusterToFlowIdList.", this.ClusterToFlowIdList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

