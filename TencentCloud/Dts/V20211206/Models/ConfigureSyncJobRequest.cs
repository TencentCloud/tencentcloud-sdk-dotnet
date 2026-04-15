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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigureSyncJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>同步实例id（即标识一个同步作业），形如sync-werwfs23，可通过<a href="https://cloud.tencent.com/document/product/571/82103">DescribeSyncJobs</a>接口获取。</p>
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// <p>源端接入类型，cdb(云数据库)、cvm(云服务器自建)、vpc(私有网络)、extranet(外网)、vpncloud(vpn接入)、dcg(专线接入)、ccn(云联网)、intranet(自研上云),注意具体可选值依赖当前链路</p>
        /// </summary>
        [JsonProperty("SrcAccessType")]
        public string SrcAccessType{ get; set; }

        /// <summary>
        /// <p>目标端接入类型，cdb(云数据库)、cvm(云服务器自建)、vpc(私有网络)、extranet(外网)、vpncloud(vpn接入)、dcg(专线接入)、ccn(云联网)、intranet(自研上云)、ckafka(CKafka实例),注意具体可选值依赖当前链路</p>
        /// </summary>
        [JsonProperty("DstAccessType")]
        public string DstAccessType{ get; set; }

        /// <summary>
        /// <p>同步库表对象信息</p>
        /// </summary>
        [JsonProperty("Objects")]
        public Objects Objects{ get; set; }

        /// <summary>
        /// <p>同步任务名称</p>
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// <p>配置任务模式，默认值为fullMode</p><p>枚举值：</p><ul><li>fullMode： 正常模式</li></ul>
        /// </summary>
        [JsonProperty("JobMode")]
        public string JobMode{ get; set; }

        /// <summary>
        /// <p>运行模式，取值如：Immediate(表示立即运行，默认为此项值)、Timed(表示定时运行)</p>
        /// </summary>
        [JsonProperty("RunMode")]
        public string RunMode{ get; set; }

        /// <summary>
        /// <p>期待启动时间，当RunMode取值为Timed时，此值必填，形如：&quot;2006-01-02 15:04:05&quot;</p>
        /// </summary>
        [JsonProperty("ExpectRunTime")]
        public string ExpectRunTime{ get; set; }

        /// <summary>
        /// <p>源端tdsql连接方式：proxy-通过tdsql proxy主机访问各个set节点，注意只有在自研上云的网络环境下才能通过这种方式连接，SrcInfos中只需要提供proxy主机信息。set-直连set节点，如选择直连set方式，需要正确填写proxy主机信息及所有set节点信息。源端是tdsqlmysql类型必填。</p>
        /// </summary>
        [JsonProperty("SrcConnectType")]
        public string SrcConnectType{ get; set; }

        /// <summary>
        /// <p>源端信息，单机版类型数据库配置使用，且SrcNodeType传single。例如mysql、percona、mariadb等。</p>
        /// </summary>
        [JsonProperty("SrcInfo")]
        public Endpoint SrcInfo{ get; set; }

        /// <summary>
        /// <p>源端信息，分布式类型数据库配置使用，且SrcNodeType传cluster。例如分布式数据库tdsqlmysql等，mongodb使用此参数透传。</p>
        /// </summary>
        [JsonProperty("SrcInfos")]
        public SyncDBEndpointInfos SrcInfos{ get; set; }

        /// <summary>
        /// <p>枚举值：cluster、single。源库为单节点数据库使用single，多节点使用cluster</p>
        /// </summary>
        [JsonProperty("SrcNodeType")]
        public string SrcNodeType{ get; set; }

        /// <summary>
        /// <p>目标端信息，单机版类型数据库配置使用，且SrcNodeType传single。例如mysql、percona、mariadb等。</p>
        /// </summary>
        [JsonProperty("DstInfo")]
        public Endpoint DstInfo{ get; set; }

        /// <summary>
        /// <p>目标端信息，分布式类型数据库配置使用，且SrcNodeType传cluster。例如分布式数据库tdsqlmysql等，mongodb使用此参数透传。</p>
        /// </summary>
        [JsonProperty("DstInfos")]
        public SyncDBEndpointInfos DstInfos{ get; set; }

        /// <summary>
        /// <p>枚举值：cluster、single。目标库为单节点数据库使用single，多节点使用cluster</p>
        /// </summary>
        [JsonProperty("DstNodeType")]
        public string DstNodeType{ get; set; }

        /// <summary>
        /// <p>同步任务选项；该字段下的RateLimitOption暂时无法生效、如果需要修改限速、可通过ModifySyncRateLimit接口完成限速</p>
        /// </summary>
        [JsonProperty("Options")]
        public Options Options{ get; set; }

        /// <summary>
        /// <p>自动重试的时间段、可设置5至720分钟、0表示不重试</p>
        /// </summary>
        [JsonProperty("AutoRetryTimeRangeMinutes")]
        public long? AutoRetryTimeRangeMinutes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "SrcAccessType", this.SrcAccessType);
            this.SetParamSimple(map, prefix + "DstAccessType", this.DstAccessType);
            this.SetParamObj(map, prefix + "Objects.", this.Objects);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "JobMode", this.JobMode);
            this.SetParamSimple(map, prefix + "RunMode", this.RunMode);
            this.SetParamSimple(map, prefix + "ExpectRunTime", this.ExpectRunTime);
            this.SetParamSimple(map, prefix + "SrcConnectType", this.SrcConnectType);
            this.SetParamObj(map, prefix + "SrcInfo.", this.SrcInfo);
            this.SetParamObj(map, prefix + "SrcInfos.", this.SrcInfos);
            this.SetParamSimple(map, prefix + "SrcNodeType", this.SrcNodeType);
            this.SetParamObj(map, prefix + "DstInfo.", this.DstInfo);
            this.SetParamObj(map, prefix + "DstInfos.", this.DstInfos);
            this.SetParamSimple(map, prefix + "DstNodeType", this.DstNodeType);
            this.SetParamObj(map, prefix + "Options.", this.Options);
            this.SetParamSimple(map, prefix + "AutoRetryTimeRangeMinutes", this.AutoRetryTimeRangeMinutes);
        }
    }
}

