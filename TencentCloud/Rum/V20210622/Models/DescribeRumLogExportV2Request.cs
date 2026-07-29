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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRumLogExportV2Request : AbstractModel
    {
        
        /// <summary>
        /// <p>Name（string，必填）：导出任务名称标识，需要在使用API创建导出任务时填写。此字段为后续能力扩展预留，不在查询结果中返回。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>查询日志开始时间(必填)</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>过滤条件，其中key与运算符(Operator)对应可选字段枚举值与示例查看文档：<a href="https://cloud.tencent.com/document/product/248/87223">日志查询相关</a></p>
        /// </summary>
        [JsonProperty("Filter")]
        public string Filter{ get; set; }

        /// <summary>
        /// <p>查询日志结束时间(必填)</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>注意：这个字段必选，不能为空！选择要导出哪些字段的参数，对应日志的列，可查看文档：<a href="https://cloud.tencent.com/document/product/248/87223">日志查询相关</a></p><p>枚举值：</p><ul><li>level： 日志类型</li><li>url： URL</li><li>ip： 用户终端IP</li><li>version： 版本</li></ul>
        /// </summary>
        [JsonProperty("Fields")]
        public string[] Fields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Filter", this.Filter);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamArraySimple(map, prefix + "Fields.", this.Fields);
        }
    }
}

