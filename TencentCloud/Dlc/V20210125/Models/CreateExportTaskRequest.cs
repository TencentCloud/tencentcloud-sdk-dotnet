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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateExportTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据来源，lakefsStorage、taskResult
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// 导出任务输入配置
        /// </summary>
        [JsonProperty("InputConf")]
        public KVPair[] InputConf{ get; set; }

        /// <summary>
        /// 导出任务输出配置
        /// </summary>
        [JsonProperty("OutputConf")]
        public KVPair[] OutputConf{ get; set; }

        /// <summary>
        /// 目标数据源的类型，目前支持导出到cos
        /// </summary>
        [JsonProperty("OutputType")]
        public string OutputType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamArrayObj(map, prefix + "InputConf.", this.InputConf);
            this.SetParamArrayObj(map, prefix + "OutputConf.", this.OutputConf);
            this.SetParamSimple(map, prefix + "OutputType", this.OutputType);
        }
    }
}

