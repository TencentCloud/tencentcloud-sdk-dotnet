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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceLogToCLSRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 日志类型：errorLog/slowLog
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 投递状态：ON/OFF
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 是否需要创建日志集
        /// </summary>
        [JsonProperty("CreateLogset")]
        public bool? CreateLogset{ get; set; }

        /// <summary>
        /// 需要创建日志集时为日志集名称；选择已有日志集时，为日志集ID
        /// </summary>
        [JsonProperty("Logset")]
        public string Logset{ get; set; }

        /// <summary>
        /// 是否需要创建日志主题
        /// </summary>
        [JsonProperty("CreateLogTopic")]
        public bool? CreateLogTopic{ get; set; }

        /// <summary>
        /// 需要创建日志主题时为日志主题名称；选择已有日志主题时，为日志主题ID
        /// </summary>
        [JsonProperty("LogTopic")]
        public string LogTopic{ get; set; }

        /// <summary>
        /// 日志主题有效期，不填写时，默认30天
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 创建日志主题时，是否创建索引
        /// </summary>
        [JsonProperty("CreateIndex")]
        public bool? CreateIndex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateLogset", this.CreateLogset);
            this.SetParamSimple(map, prefix + "Logset", this.Logset);
            this.SetParamSimple(map, prefix + "CreateLogTopic", this.CreateLogTopic);
            this.SetParamSimple(map, prefix + "LogTopic", this.LogTopic);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "CreateIndex", this.CreateIndex);
        }
    }
}

