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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCloudProductLogCollectionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p><ul><li>通过各个接入云产品官方文档获取</li></ul>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>云产品标识。支持以下产品</p><ul><li>APIS</li><li>BH</li><li>CDB</li><li>CDS</li><li>CFS</li><li>CLB</li><li>CSIP</li><li>CWP</li><li>DCDB</li><li>DNSPod</li><li>EMR</li><li>HTTPDNS</li><li>KHL</li><li>llmsgw</li><li>MariaDB</li><li>MDP</li><li>MongoDB</li><li>PostgreSQL</li><li>TCSS</li><li>TDSQL-C</li><li>TDStore</li><li>TencentDB-Redis</li><li>TEO</li><li>TokenHub</li><li>TSE</li></ul>
        /// </summary>
        [JsonProperty("AssumerName")]
        public string AssumerName{ get; set; }

        /// <summary>
        /// <p>各云产品支持的日志类型如下：</p><table><thead><tr><th>assumer_name</th><th>支持的 log_type</th></tr></thead><tbody><tr><td>APIS</td><td>APIS-ACCESS</td></tr><tr><td>BH</td><td>BH-COMMANDLOG, BH-FILELOG</td></tr><tr><td>CDB</td><td>CDB-AUDIT</td></tr><tr><td>CDS</td><td>CDS-AUDIT, CDS-RISK</td></tr><tr><td>CFS</td><td>CFS-AUDIT</td></tr><tr><td>CLB</td><td>CMR-SPEND</td></tr><tr><td>CSIP</td><td>CSIP</td></tr><tr><td>CWP</td><td>CWP</td></tr><tr><td>DCDB</td><td>DCDB-AUDIT, DCDB-ERROR, DCDB-SLOW</td></tr><tr><td>DNSPod</td><td>DNSPod-RESOLVELOG</td></tr><tr><td>EMR</td><td>EMR-OPERATION</td></tr><tr><td>HTTPDNS</td><td>HTTPDNS-RESOLVELOG</td></tr><tr><td>MariaDB</td><td>MariaDB-AUDIT, MariaDB-ERROR, MariaDB-SLOW</td></tr><tr><td>MDP</td><td>MDP-SSAI</td></tr><tr><td>MongoDB</td><td>MongoDB-AUDIT, MongoDB-ErrorLog, MongoDB-OperationLog, MongoDB-SlowLog</td></tr><tr><td>PostgreSQL</td><td>PostgreSQL-AUDIT, PostgreSQL-ERROR, PostgreSQL-SLOW</td></tr><tr><td>TCSS</td><td>TCSS</td></tr><tr><td>TDSQL-C</td><td>TDSQL-C-AUDIT</td></tr><tr><td>TDStore</td><td>TDMYSQL-SLOW</td></tr><tr><td>TencentDB-Redis</td><td>Redis-AUDIT, Redis-ERROR, Redis-SLOW</td></tr><tr><td>TEO</td><td>TEO-INEFERENCE</td></tr><tr><td>llmsgw</td><td>llmsgw-mcp-security-alarm</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>云产品地域。不同 LogType 入参格式存在差异：</p><p><strong>格式 A：短 region 码</strong>（gz / sh / bj …）</p><ul><li>APIS 全部日志类型：如 <code>gz</code></li><li>CDB-AUDIT</li><li>TDSQL-C-AUDIT</li><li>TDMYSQL-SLOW</li><li>DCDB 全部日志类型</li><li>MariaDB 全部日志类型</li><li>PostgreSQL 全部日志类型</li><li>MongoDB-AUDIT（<strong>注意与 SlowLog/ErrorLog/OperationLog 不同</strong>）</li><li>TencentDB-Redis 全部日志类型</li><li>EMR-OPERATION</li></ul><p><strong>格式 B：长 region 码</strong>（ap-guangzhou / ap-shanghai / ap-singapore …）</p><ul><li>CDS 全部日志类型：如 <code>ap-guangzhou</code></li><li>MongoDB-SlowLog / MongoDB-ErrorLog / MongoDB-OperationLog</li><li>DNSPod-RESOLVELOG</li><li>HTTPDNS-RESOLVELOG</li><li>MDP-SSAI</li><li>CFS-AUDIT</li><li>TEO-INEFERENCE</li><li>TokenHub-ActivityLog / TokenHub-AuditLog</li><li>llmsgw-mcp-security-alarm</li><li>CSIP / TCSS / TSE / CWP / KHL 等</li></ul><p><strong>格式 C：BH 专用 Polaris 名</strong></p><ul><li>BH 全部日志类型：<code>overseas-polaris</code>（中国香港及其他海外）/ <code>fsi-polaris</code>（金融区）/ <code>general-polaris</code>（普通区）/ <code>intl-sg-prod</code>（国际站）</li></ul>
        /// </summary>
        [JsonProperty("CloudProductRegion")]
        public string CloudProductRegion{ get; set; }

        /// <summary>
        /// <p>CLS目标地域</p><ul><li>支持地域参考  <a href="https://cloud.tencent.com/document/api/614/56474#.E5.9C.B0.E5.9F.9F.E5.88.97.E8.A1.A8">地域列表</a> 文档</li></ul>
        /// </summary>
        [JsonProperty("ClsRegion")]
        public string ClsRegion{ get; set; }

        /// <summary>
        /// <p>日志集名称，未填LogsetId时必填。若日志集不存在, 将自动创建</p>
        /// </summary>
        [JsonProperty("LogsetName")]
        public string LogsetName{ get; set; }

        /// <summary>
        /// <p>日志主题名称，在未填TopicId时必填。 若日志主题不存在，将自动创建</p>
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// <p>日志配置扩展信息， 一般用于存储额外的日志投递配置</p>
        /// </summary>
        [JsonProperty("Extend")]
        public string Extend{ get; set; }

        /// <summary>
        /// <p>日志集id</p><ul><li>通过<a href="https://cloud.tencent.com/document/api/614/58624">获取日志集列表</a>获取日志集Id。</li></ul>
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// <p>日志主题id</p><ul><li>通过<a href="https://cloud.tencent.com/document/product/614/56454">获取日志主题列表</a>获取日志主题Id。</li></ul>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>标签描述列表，通过指定该参数可以同时绑定标签到相应的主题。最大支持10个标签键值对，同一个资源只能绑定到同一个标签键下。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AssumerName", this.AssumerName);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "CloudProductRegion", this.CloudProductRegion);
            this.SetParamSimple(map, prefix + "ClsRegion", this.ClsRegion);
            this.SetParamSimple(map, prefix + "LogsetName", this.LogsetName);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "Extend", this.Extend);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

