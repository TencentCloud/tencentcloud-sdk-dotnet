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
        /// 数据项ID，调用[DescribePrograms](https://console.cloud.tencent.com/tsf/privilege?rid=1&tab=program)接口查询已创建的数据集或登陆控制台进行查看；也可以通过调用[CreateProgram](https://cloud.tencent.com/document/api/649/108544)创建新的数据集。
        /// </summary>
        [JsonProperty("ProgramItemId")]
        public string ProgramItemId{ get; set; }

        /// <summary>
        /// 资源
        /// </summary>
        [JsonProperty("Resource")]
        public Resource Resource{ get; set; }

        /// <summary>
        /// 数据值列表
        /// </summary>
        [JsonProperty("ValueList")]
        public string[] ValueList{ get; set; }

        /// <summary>
        /// 全选标识，true: 全选；false: 非全选
        /// </summary>
        [JsonProperty("IsAll")]
        public bool? IsAll{ get; set; }

        /// <summary>
        /// 创建时间，时间戳格式【Long】
        /// </summary>
        [JsonProperty("CreationTime")]
        public long? CreationTime{ get; set; }

        /// <summary>
        /// 最后更新时间，时间戳格式【Long】，单位毫秒
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public long? LastUpdateTime{ get; set; }

        /// <summary>
        /// 删除标识，true: 可删除；false: 不可删除
        /// </summary>
        [JsonProperty("DeleteFlag")]
        public bool? DeleteFlag{ get; set; }

        /// <summary>
        /// 数据集ID，调用[DescribePrograms](https://console.cloud.tencent.com/tsf/privilege?rid=1&tab=program)查询接口获取
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

