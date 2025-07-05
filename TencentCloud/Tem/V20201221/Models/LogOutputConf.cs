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

namespace TencentCloud.Tem.V20201221.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogOutputConf : AbstractModel
    {
        
        /// <summary>
        /// 日志消费端类型
        /// </summary>
        [JsonProperty("OutputType")]
        public string OutputType{ get; set; }

        /// <summary>
        /// cls日志集
        /// </summary>
        [JsonProperty("ClsLogsetName")]
        public string ClsLogsetName{ get; set; }

        /// <summary>
        /// cls日志主题
        /// </summary>
        [JsonProperty("ClsLogTopicId")]
        public string ClsLogTopicId{ get; set; }

        /// <summary>
        /// cls日志集id
        /// </summary>
        [JsonProperty("ClsLogsetId")]
        public string ClsLogsetId{ get; set; }

        /// <summary>
        /// cls日志名称
        /// </summary>
        [JsonProperty("ClsLogTopicName")]
        public string ClsLogTopicName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutputType", this.OutputType);
            this.SetParamSimple(map, prefix + "ClsLogsetName", this.ClsLogsetName);
            this.SetParamSimple(map, prefix + "ClsLogTopicId", this.ClsLogTopicId);
            this.SetParamSimple(map, prefix + "ClsLogsetId", this.ClsLogsetId);
            this.SetParamSimple(map, prefix + "ClsLogTopicName", this.ClsLogTopicName);
        }
    }
}

