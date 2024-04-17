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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CallBackInfo : AbstractModel
    {
        
        /// <summary>
        /// 回调时的Body。
        /// 可将各类告警变量放在请求内容中，详见[帮助文档](https://cloud.tencent.com/document/product/614/74718)。
        /// 如下示例：
        /// 
        /// ```
        /// {
        /// "TopicId": "{{ .QueryLog[0][0].topicId }}",
        /// "key": "{{.Alarm}}",
        /// "time": "{{ .QueryLog[0][0].time }}",
        /// "log": "{{ .QueryLog[0][0].content.__CONTENT__ }}",
        /// "namespace": "{{ .QueryLog[0][0].content.__TAG__.namespace }}"
        /// }
        /// ```
        /// </summary>
        [JsonProperty("Body")]
        public string Body{ get; set; }

        /// <summary>
        /// 回调时的HTTP请求头部字段。
        /// 例如：下面请求头部字段来告知服务器请求主体的内容类型为JSON。
        /// ```
        /// "Content-Type: application/json"
        /// ```
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Headers")]
        public string[] Headers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Body", this.Body);
            this.SetParamArraySimple(map, prefix + "Headers.", this.Headers);
        }
    }
}

