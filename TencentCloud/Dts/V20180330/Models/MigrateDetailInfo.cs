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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MigrateDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 总步骤数
        /// </summary>
        [JsonProperty("StepAll")]
        public long? StepAll{ get; set; }

        /// <summary>
        /// 当前步骤
        /// </summary>
        [JsonProperty("StepNow")]
        public long? StepNow{ get; set; }

        /// <summary>
        /// 总进度,如：
        /// </summary>
        [JsonProperty("Progress")]
        public string Progress{ get; set; }

        /// <summary>
        /// 当前步骤进度,如:
        /// </summary>
        [JsonProperty("CurrentStepProgress")]
        public string CurrentStepProgress{ get; set; }

        /// <summary>
        /// 主从差距，MB
        /// </summary>
        [JsonProperty("MasterSlaveDistance")]
        public long? MasterSlaveDistance{ get; set; }

        /// <summary>
        /// 主从差距，秒
        /// </summary>
        [JsonProperty("SecondsBehindMaster")]
        public long? SecondsBehindMaster{ get; set; }

        /// <summary>
        /// 步骤信息
        /// </summary>
        [JsonProperty("StepInfo")]
        public MigrateStepDetailInfo[] StepInfo{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StepAll", this.StepAll);
            this.SetParamSimple(map, prefix + "StepNow", this.StepNow);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "CurrentStepProgress", this.CurrentStepProgress);
            this.SetParamSimple(map, prefix + "MasterSlaveDistance", this.MasterSlaveDistance);
            this.SetParamSimple(map, prefix + "SecondsBehindMaster", this.SecondsBehindMaster);
            this.SetParamArrayObj(map, prefix + "StepInfo.", this.StepInfo);
        }
    }
}

