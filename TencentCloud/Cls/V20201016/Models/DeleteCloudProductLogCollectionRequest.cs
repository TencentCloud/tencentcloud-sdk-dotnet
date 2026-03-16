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

    public class DeleteCloudProductLogCollectionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
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
        /// <p>云产品地域。 不同日志类型(LogType)地域入参格式存在差异， 请参考如下示例：</p><ul><li>CDS所有日志类型：ap-guangzhou</li><li>CDB-AUDIT: gz</li><li>TDSQL-C-AUDIT: gz</li><li>MongoDB-AUDIT: gz</li><li>MongoDB-SlowLog：ap-guangzhou</li><li>MongoDB-ErrorLog：ap-guangzhou</li><li>TDMYSQL-SLOW：gz</li><li>DCDB所有日志类型：gz</li><li>MariaDB所有日志类型：gz</li><li>PostgreSQL所有日志类型：gz</li><li>BH所有日志类型：overseas-polaris(中国香港地区和其他)/fsi-polaris(金融区)/general-polaris(普通区)/intl-sg-prod(国际站)</li><li>APIS所有日志类型：gz</li></ul>
        /// </summary>
        [JsonProperty("CloudProductRegion")]
        public string CloudProductRegion{ get; set; }

        /// <summary>
        /// <p>是否删除关联的topic</p>
        /// </summary>
        [JsonProperty("IsDeleteTopic")]
        public bool? IsDeleteTopic{ get; set; }

        /// <summary>
        /// <p>是否删除关联的logset。如果logset下还有topic的话，不会进行删除</p>
        /// </summary>
        [JsonProperty("IsDeleteLogset")]
        public bool? IsDeleteLogset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AssumerName", this.AssumerName);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "CloudProductRegion", this.CloudProductRegion);
            this.SetParamSimple(map, prefix + "IsDeleteTopic", this.IsDeleteTopic);
            this.SetParamSimple(map, prefix + "IsDeleteLogset", this.IsDeleteLogset);
        }
    }
}

