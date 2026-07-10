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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RealtimeLogDeliveryTask : AbstractModel
    {
        
        /// <summary>
        /// <p>实时日志投递任务 ID。</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>实时日志投递任务的名称。</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>实时日志投递任务的状态，取值有： <li>enabled: 已启用；</li> <li>disabled: 已停用；</li><li>deleted: 异常删除状态，请检查目的地腾讯云 CLS 日志集/日志主题是否已被删除。</li></p>
        /// </summary>
        [JsonProperty("DeliveryStatus")]
        public string DeliveryStatus{ get; set; }

        /// <summary>
        /// <p>实时日志投递任务类型，取值有： <li>cls: 推送到腾讯云 CLS；</li> <li>custom_endpoint：推送到自定义 HTTP(S) 地址；</li> <li>s3：推送到 AWS S3 兼容存储桶地址；</li><li>log_analysis：推送到 EdgeOne 日志分析。</li></p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>实时日志投递任务对应的实体（七层域名或者四层代理实例）列表。取值示例如下： <li>七层域名：domain.example.com；</li> <li>四层代理实例：sid-2s69eb5wcms7。</li></p>
        /// </summary>
        [JsonProperty("EntityList")]
        public string[] EntityList{ get; set; }

        /// <summary>
        /// <p>数据投递类型，取值有： <li>l7-access-logs：七层访问日志；</li><li>application：四层代理日志；</li> <li>function：边缘函数运行日志；</li> <li>web-attack：托管规则日志；</li> <li>domain：站点加速日志；</li> <li>web-rateLiming：速率限制和 CC 攻击防护日志；</li><li>web-rule：自定义规则日志；</li> <li>web-bot：Bot 管理日志。</li></p>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>数据投递区域，取值有： <li>mainland：中国大陆境内；</li> <li>overseas：全球（不含中国大陆）。</li></p>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>投递的预设字段列表。</p>
        /// </summary>
        [JsonProperty("Fields")]
        public string[] Fields{ get; set; }

        /// <summary>
        /// <p>投递的自定义字段列表。</p>
        /// </summary>
        [JsonProperty("CustomFields")]
        public CustomField[] CustomFields{ get; set; }

        /// <summary>
        /// <p>日志投递的过滤条件。</p>
        /// </summary>
        [JsonProperty("DeliveryConditions")]
        public DeliveryCondition[] DeliveryConditions{ get; set; }

        /// <summary>
        /// <p>采样比例，采用千分制，取值范围为1-1000，例如：605 表示采样比例为 60.5%。</p>
        /// </summary>
        [JsonProperty("Sample")]
        public ulong? Sample{ get; set; }

        /// <summary>
        /// <p>日志投递的输出格式。出参为 null 时表示为默认格式，默认格式逻辑如下：</p><li>当 TaskType 取值为 custom_endpoint 时，默认格式为多个 JSON 对象组成的数组，每个 JSON 对象为一条日志；</li><li>当 TaskType 取值为 s3 时，默认格式为 JSON Lines。</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogFormat")]
        public LogFormat LogFormat{ get; set; }

        /// <summary>
        /// <p>CLS 的配置信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CLS")]
        public CLSTopic CLS{ get; set; }

        /// <summary>
        /// <p>自定义 HTTP 服务的配置信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomEndpoint")]
        public CustomEndpoint CustomEndpoint{ get; set; }

        /// <summary>
        /// <p>AWS S3 兼容存储桶的配置信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("S3")]
        public S3 S3{ get; set; }

        /// <summary>
        /// <p>创建时间。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间。</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "DeliveryStatus", this.DeliveryStatus);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArraySimple(map, prefix + "EntityList.", this.EntityList);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamArraySimple(map, prefix + "Fields.", this.Fields);
            this.SetParamArrayObj(map, prefix + "CustomFields.", this.CustomFields);
            this.SetParamArrayObj(map, prefix + "DeliveryConditions.", this.DeliveryConditions);
            this.SetParamSimple(map, prefix + "Sample", this.Sample);
            this.SetParamObj(map, prefix + "LogFormat.", this.LogFormat);
            this.SetParamObj(map, prefix + "CLS.", this.CLS);
            this.SetParamObj(map, prefix + "CustomEndpoint.", this.CustomEndpoint);
            this.SetParamObj(map, prefix + "S3.", this.S3);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

