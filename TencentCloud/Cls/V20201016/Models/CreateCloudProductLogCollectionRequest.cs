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
        /// <p>云产品标识，支持枚举：CDS、CWP、CDB、TDSQL-C、MongoDB、TDStore、DCDB、MariaDB、PostgreSQL、BH、APIS</p>
        /// </summary>
        [JsonProperty("AssumerName")]
        public string AssumerName{ get; set; }

        /// <summary>
        /// <p>日志类型，支持枚举：CDS-AUDIT、CDS-RISK、CDB-AUDIT、TDSQL-C-AUDIT、MongoDB-AUDIT、MongoDB-SlowLog、MongoDB-ErrorLog、TDMYSQL-SLOW、DCDB-AUDIT、DCDB-SLOW、DCDB-ERROR、MariaDB-AUDIT、MariaDB-SLOW、MariaDB-ERROR、PostgreSQL-SLOW、PostgreSQL-ERROR、PostgreSQL-AUDIT、BH-FILELOG、BH-COMMANDLOG、APIS-ACCESS</p>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>云产品地域。 不同日志类型(LogType)地域入参格式存在差异， 请参考如下示例：</p><ul><li>CDS所有日志类型：ap-guangzhou</li><li>CDB-AUDIT: gz</li><li>TDSQL-C-AUDIT:  gz</li><li>MongoDB-AUDIT:  gz</li><li>MongoDB-SlowLog：ap-guangzhou</li><li>MongoDB-ErrorLog：ap-guangzhou</li><li>TDMYSQL-SLOW：gz</li><li>DCDB所有日志类型：gz</li><li>MariaDB所有日志类型：gz</li><li>PostgreSQL所有日志类型：gz</li><li>BH所有日志类型：overseas-polaris(中国香港地区和其他)/fsi-polaris(金融区)/general-polaris(普通区)/intl-sg-prod(国际站)</li><li>APIS所有日志类型：gz</li></ul>
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

