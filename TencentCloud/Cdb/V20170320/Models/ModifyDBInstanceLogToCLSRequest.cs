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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceLogToCLSRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID，可通过 <a href="https://cloud.tencent.com/document/product/236/15872">DescribeDBInstances</a> 接口获取。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>日志类型。error：错误日志，slowlog：慢日志。</p>
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
        /// <p>需要创建日志集时为日志集名称；选择已有日志集时，为日志集 ID。默认为空。<br>说明：当参数 Status 的值为 ON 时，Logset 和 LogTopic 参数必须填一个。</p>
        /// </summary>
        [JsonProperty("Logset")]
        public string Logset{ get; set; }

        /// <summary>
        /// <p>是否需要创建日志主题。默认为 false。</p>
        /// </summary>
        [JsonProperty("CreateLogTopic")]
        public bool? CreateLogTopic{ get; set; }

        /// <summary>
        /// <p>需要创建日志主题时为日志主题名称；选择已有日志主题时，为日志主题 ID。默认为空。<br>说明：当参数 Status 的值为 ON 时，Logset 和 LogTopic 参数必须填一个。</p>
        /// </summary>
        [JsonProperty("LogTopic")]
        public string LogTopic{ get; set; }

        /// <summary>
        /// <p>日志主题有效期，不填写时，默认30天，最大值3600。</p>
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// <p>创建日志主题时，是否创建索引，默认为 false。</p>
        /// </summary>
        [JsonProperty("CreateIndex")]
        public bool? CreateIndex{ get; set; }

        /// <summary>
        /// <p>CLS 所在地域，不填择默认为 Region 的参数值。</p>
        /// </summary>
        [JsonProperty("ClsRegion")]
        public string ClsRegion{ get; set; }

        /// <summary>
        /// <p>创建日志集和日志主题的时候可选，最多不能超过10个标签</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public TagInfoItem[] ResourceTags{ get; set; }


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
            this.SetParamSimple(map, prefix + "ClsRegion", this.ClsRegion);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
        }
    }
}

