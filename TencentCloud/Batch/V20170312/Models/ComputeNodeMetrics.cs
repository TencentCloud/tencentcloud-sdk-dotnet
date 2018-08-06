/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComputeNodeMetrics : AbstractModel
    {
        
        /// <summary>
        /// 已经完成提交的计算节点数量
        /// </summary>
        [JsonProperty("SubmittedCount")]
        public string SubmittedCount{ get; set; }

        /// <summary>
        /// 创建中的计算节点数量
        /// </summary>
        [JsonProperty("CreatingCount")]
        public string CreatingCount{ get; set; }

        /// <summary>
        /// 创建失败的计算节点数量
        /// </summary>
        [JsonProperty("CreationFailedCount")]
        public string CreationFailedCount{ get; set; }

        /// <summary>
        /// 完成创建的计算节点数量
        /// </summary>
        [JsonProperty("CreatedCount")]
        public string CreatedCount{ get; set; }

        /// <summary>
        /// 运行中的计算节点数量
        /// </summary>
        [JsonProperty("RunningCount")]
        public string RunningCount{ get; set; }

        /// <summary>
        /// 销毁中的计算节点数量
        /// </summary>
        [JsonProperty("DeletingCount")]
        public string DeletingCount{ get; set; }

        /// <summary>
        /// 异常的计算节点数量
        /// </summary>
        [JsonProperty("AbnormalCount")]
        public string AbnormalCount{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubmittedCount", this.SubmittedCount);
            this.SetParamSimple(map, prefix + "CreatingCount", this.CreatingCount);
            this.SetParamSimple(map, prefix + "CreationFailedCount", this.CreationFailedCount);
            this.SetParamSimple(map, prefix + "CreatedCount", this.CreatedCount);
            this.SetParamSimple(map, prefix + "RunningCount", this.RunningCount);
            this.SetParamSimple(map, prefix + "DeletingCount", this.DeletingCount);
            this.SetParamSimple(map, prefix + "AbnormalCount", this.AbnormalCount);
        }
    }
}

