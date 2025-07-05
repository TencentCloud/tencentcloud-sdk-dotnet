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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TerminateClusterNodesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 销毁资源列表
        /// </summary>
        [JsonProperty("CvmInstanceIds")]
        public string[] CvmInstanceIds{ get; set; }

        /// <summary>
        /// 销毁节点类型取值范围：
        ///   <li>MASTER</li>
        ///   <li>TASK</li>
        ///   <li>CORE</li>
        ///   <li>ROUTER</li>
        /// </summary>
        [JsonProperty("NodeFlag")]
        public string NodeFlag{ get; set; }

        /// <summary>
        /// 优雅缩容开关
        ///   <li>true:开启</li>
        ///   <li>false:不开启</li>
        /// </summary>
        [JsonProperty("GraceDownFlag")]
        public bool? GraceDownFlag{ get; set; }

        /// <summary>
        /// 优雅缩容等待时间,时间范围60到1800  单位秒
        /// </summary>
        [JsonProperty("GraceDownTime")]
        public long? GraceDownTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "CvmInstanceIds.", this.CvmInstanceIds);
            this.SetParamSimple(map, prefix + "NodeFlag", this.NodeFlag);
            this.SetParamSimple(map, prefix + "GraceDownFlag", this.GraceDownFlag);
            this.SetParamSimple(map, prefix + "GraceDownTime", this.GraceDownTime);
        }
    }
}

