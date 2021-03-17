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

    public class DescribeInstanceRenewNodesResponse : AbstractModel
    {
        
        /// <summary>
        /// 查询到的节点总数
        /// </summary>
        [JsonProperty("TotalCnt")]
        public long? TotalCnt{ get; set; }

        /// <summary>
        /// 节点详细信息列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeList")]
        public RenewInstancesInfo[] NodeList{ get; set; }

        /// <summary>
        /// 用户所有的标签键列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetaInfo")]
        public string[] MetaInfo{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalCnt", this.TotalCnt);
            this.SetParamArrayObj(map, prefix + "NodeList.", this.NodeList);
            this.SetParamArraySimple(map, prefix + "MetaInfo.", this.MetaInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

