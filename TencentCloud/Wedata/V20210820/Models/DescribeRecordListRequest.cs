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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRecordListRequest : AbstractModel
    {
        
        /// <summary>
        /// 脚本文件id
        /// </summary>
        [JsonProperty("ScriptId")]
        public string ScriptId{ get; set; }

        /// <summary>
        /// 分页索引
        /// </summary>
        [JsonProperty("PageIndex")]
        public ulong? PageIndex{ get; set; }

        /// <summary>
        /// 单页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 脚本类型
        /// </summary>
        [JsonProperty("ScriptType")]
        public string ScriptType{ get; set; }

        /// <summary>
        /// sql语句
        /// </summary>
        [JsonProperty("SqlStatement")]
        public string SqlStatement{ get; set; }

        /// <summary>
        /// 开始时间(毫秒)
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 结束时间(毫秒)
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 是否只查看用户自身的调试记录,默认或者不填都为true，填为false的时候会显示其他用户的此脚本的调试记录
        /// </summary>
        [JsonProperty("IsOnlyMyselfDebug")]
        public bool? IsOnlyMyselfDebug{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScriptId", this.ScriptId);
            this.SetParamSimple(map, prefix + "PageIndex", this.PageIndex);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "ScriptType", this.ScriptType);
            this.SetParamSimple(map, prefix + "SqlStatement", this.SqlStatement);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsOnlyMyselfDebug", this.IsOnlyMyselfDebug);
        }
    }
}

