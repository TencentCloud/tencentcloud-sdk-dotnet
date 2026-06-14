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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceLogToCLSRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>指定实例ID。例如：cmgo-p8vn****。请登录 MongoDB 控制台在实例列表复制实例 ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>日志类型。MongoDB-ErrorLog：错误日志，MongoDB-SlowLog：慢日志，MongoDB-OperationLog：操作日志</p>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>投递状态。ON：开启，OFF：关闭。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>是否需要创建日志集。默认为 false。</p>
        /// </summary>
        [JsonProperty("CreateLogset")]
        public bool? CreateLogset{ get; set; }

        /// <summary>
        /// <p>需要创建日志集时为日志集名称；选择已有日志集时，为日志集 ID。默认为空。 说明：1. 当参数 Status 的值为 ON 时，Logset 和 LogTopic 参数必须填一个。2.  当参数 CreateLogset 的值为 true 时，Logset 填日志集命名，例如 my_test，否则需要填日志集 id，例如 6adsaw-****。</p>
        /// </summary>
        [JsonProperty("Logset")]
        public string Logset{ get; set; }

        /// <summary>
        /// <p>是否需要创建日志主题。默认为 false。</p>
        /// </summary>
        [JsonProperty("CreateLogTopic")]
        public bool? CreateLogTopic{ get; set; }

        /// <summary>
        /// <p>需要创建日志主题时为日志主题名称；选择已有日志主题时，为日志主题 ID。默认为空。 说明：1. 当参数 Status 的值为 ON 时，Logset 和 LogTopic 参数必须填一个。2. 2.  当参数 CreateLogTopic 的值为 true 时，LogTopic 填日志主题命名，例如 my_test，否则需要填日志主题id，例如 6adsaw-****。</p>
        /// </summary>
        [JsonProperty("LogTopic")]
        public string LogTopic{ get; set; }

        /// <summary>
        /// <p>CLS 所在地域，不填则默认为 Region 的参数值。</p>
        /// </summary>
        [JsonProperty("CLSRegion")]
        public string CLSRegion{ get; set; }


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
            this.SetParamSimple(map, prefix + "CLSRegion", this.CLSRegion);
        }
    }
}

