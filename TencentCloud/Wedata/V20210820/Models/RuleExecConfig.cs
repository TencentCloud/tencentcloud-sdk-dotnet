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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleExecConfig : AbstractModel
    {
        
        /// <summary>
        /// 计算队列名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// 执行资源组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// 运行的执行引擎，不传时会请求该数据源下默认的执行引擎
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// DLC执行引擎资源组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DlcGroupName")]
        public string DlcGroupName{ get; set; }

        /// <summary>
        /// 引擎参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineParam")]
        public string EngineParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "ExecutorGroupId", this.ExecutorGroupId);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "DlcGroupName", this.DlcGroupName);
            this.SetParamSimple(map, prefix + "EngineParam", this.EngineParam);
        }
    }
}

