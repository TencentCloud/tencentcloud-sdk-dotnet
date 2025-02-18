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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DockerActivity : AbstractModel
    {
        
        /// <summary>
        /// 活动ID。
        /// </summary>
        [JsonProperty("ActivityId")]
        public string ActivityId{ get; set; }

        /// <summary>
        /// 活动名称。
        /// </summary>
        [JsonProperty("ActivityName")]
        public string ActivityName{ get; set; }

        /// <summary>
        /// 活动状态。取值范围： 
        /// <li>INIT：表示初始化，活动尚未执行</li>
        /// <li>OPERATING：表示活动执行中</li>
        /// <li>SUCCESS：表示活动执行成功</li>
        /// <li>FAILED：表示活动执行失败</li>
        /// </summary>
        [JsonProperty("ActivityState")]
        public string ActivityState{ get; set; }

        /// <summary>
        /// 活动执行的命令输出，以base64编码。
        /// </summary>
        [JsonProperty("ActivityCommandOutput")]
        public string ActivityCommandOutput{ get; set; }

        /// <summary>
        /// 容器ID列表。
        /// </summary>
        [JsonProperty("ContainerIds")]
        public string[] ContainerIds{ get; set; }

        /// <summary>
        /// 创建时间。按照 ISO8601 标准表示，并且使用 UTC 时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 结束时间。按照 ISO8601 标准表示，并且使用 UTC 时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "ActivityName", this.ActivityName);
            this.SetParamSimple(map, prefix + "ActivityState", this.ActivityState);
            this.SetParamSimple(map, prefix + "ActivityCommandOutput", this.ActivityCommandOutput);
            this.SetParamArraySimple(map, prefix + "ContainerIds.", this.ContainerIds);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

