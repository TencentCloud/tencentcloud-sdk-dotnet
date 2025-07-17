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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindProjectExecutorResourceRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行资源组id
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 需要绑定项目的资源包id集合，为空则绑定整个资源组
        /// </summary>
        [JsonProperty("ExecutorResourcePackageIds")]
        public string[] ExecutorResourcePackageIds{ get; set; }

        /// <summary>
        /// 可选: 需要绑定的多个项目id, 若申明将带上ProjectId一起绑定
        /// </summary>
        [JsonProperty("ProjectIdList")]
        public string[] ProjectIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExecutorGroupId", this.ExecutorGroupId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "ExecutorResourcePackageIds.", this.ExecutorResourcePackageIds);
            this.SetParamArraySimple(map, prefix + "ProjectIdList.", this.ProjectIdList);
        }
    }
}

