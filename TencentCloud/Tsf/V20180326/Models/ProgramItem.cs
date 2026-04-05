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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProgramItem : AbstractModel
    {
        
        /// <summary>
        /// <p>数据项ID，调用<a href="https://console.cloud.tencent.com/tsf/privilege?rid=1&amp;tab=program">DescribePrograms</a>接口查询已创建的数据集或登录控制台进行查看；也可以通过调用<a href="https://cloud.tencent.com/document/api/649/108544">CreateProgram</a>创建新的数据集。</p>
        /// </summary>
        [JsonProperty("ProgramItemId")]
        public string ProgramItemId{ get; set; }

        /// <summary>
        /// <p>资源</p>
        /// </summary>
        [JsonProperty("Resource")]
        public Resource Resource{ get; set; }

        /// <summary>
        /// <p>数据值列表</p>
        /// </summary>
        [JsonProperty("ValueList")]
        public string[] ValueList{ get; set; }

        /// <summary>
        /// <p>全选标识，true: 全选；false: 非全选</p>
        /// </summary>
        [JsonProperty("IsAll")]
        public bool? IsAll{ get; set; }

        /// <summary>
        /// <p>创建时间，时间戳格式【Long】</p>
        /// </summary>
        [JsonProperty("CreationTime")]
        public long? CreationTime{ get; set; }

        /// <summary>
        /// <p>最后更新时间，时间戳格式【Long】，单位毫秒</p>
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public long? LastUpdateTime{ get; set; }

        /// <summary>
        /// <p>删除标识，true: 可删除；false: 不可删除</p>
        /// </summary>
        [JsonProperty("DeleteFlag")]
        public bool? DeleteFlag{ get; set; }

        /// <summary>
        /// <p>数据集ID，调用<a href="https://console.cloud.tencent.com/tsf/privilege?rid=1&amp;tab=program">DescribePrograms</a>查询接口获取</p>
        /// </summary>
        [JsonProperty("ProgramId")]
        public string ProgramId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProgramItemId", this.ProgramItemId);
            this.SetParamObj(map, prefix + "Resource.", this.Resource);
            this.SetParamArraySimple(map, prefix + "ValueList.", this.ValueList);
            this.SetParamSimple(map, prefix + "IsAll", this.IsAll);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamSimple(map, prefix + "DeleteFlag", this.DeleteFlag);
            this.SetParamSimple(map, prefix + "ProgramId", this.ProgramId);
        }
    }
}

