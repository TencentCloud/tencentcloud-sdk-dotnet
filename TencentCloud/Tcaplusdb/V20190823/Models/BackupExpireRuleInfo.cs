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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupExpireRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// 所属表格组ID
        /// </summary>
        [JsonProperty("TableGroupId")]
        public string TableGroupId{ get; set; }

        /// <summary>
        /// 表名称
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 文件标签，见上面描述
        /// </summary>
        [JsonProperty("FileTag")]
        public ulong? FileTag{ get; set; }

        /// <summary>
        /// 淘汰天数，见上面描述
        /// </summary>
        [JsonProperty("ExpireDay")]
        public ulong? ExpireDay{ get; set; }

        /// <summary>
        /// 操作类型，见上面描述
        /// </summary>
        [JsonProperty("OperType")]
        public ulong? OperType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableGroupId", this.TableGroupId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "FileTag", this.FileTag);
            this.SetParamSimple(map, prefix + "ExpireDay", this.ExpireDay);
            this.SetParamSimple(map, prefix + "OperType", this.OperType);
        }
    }
}

