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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySyncJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 待修改的灾备同步任务ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 灾备同步任务名称
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// 灾备同步任务配置选项
        /// </summary>
        [JsonProperty("SyncOption")]
        public SyncOption SyncOption{ get; set; }

        /// <summary>
        /// 当选择'指定库表'灾备同步的时候, 需要设置待同步的源数据库表信息,用符合json数组格式的字符串描述, 如下所例。
        /// 对于database-table两级结构的数据库：
        /// [{"Database":"db1","Table":["table1","table2"]},{"Database":"db2"}]
        /// </summary>
        [JsonProperty("DatabaseInfo")]
        public string DatabaseInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamObj(map, prefix + "SyncOption.", this.SyncOption);
            this.SetParamSimple(map, prefix + "DatabaseInfo", this.DatabaseInfo);
        }
    }
}

