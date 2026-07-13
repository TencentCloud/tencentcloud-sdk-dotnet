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

    public class ApplicationAttribute : AbstractModel
    {
        
        /// <summary>
        /// <p>总实例个数</p>
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// <p>运行实例个数</p>
        /// </summary>
        [JsonProperty("RunInstanceCount")]
        public long? RunInstanceCount{ get; set; }

        /// <summary>
        /// <p>应用下部署组个数</p>
        /// </summary>
        [JsonProperty("GroupCount")]
        public long? GroupCount{ get; set; }

        /// <summary>
        /// <p>运行中部署组个数</p>
        /// </summary>
        [JsonProperty("RunningGroupCount")]
        public string RunningGroupCount{ get; set; }

        /// <summary>
        /// <p>异常部署组个数</p>
        /// </summary>
        [JsonProperty("AbnormalCount")]
        public string AbnormalCount{ get; set; }

        /// <summary>
        /// <p>镜像tag数量</p>
        /// </summary>
        [JsonProperty("ImageTagCount")]
        public long? ImageTagCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "RunInstanceCount", this.RunInstanceCount);
            this.SetParamSimple(map, prefix + "GroupCount", this.GroupCount);
            this.SetParamSimple(map, prefix + "RunningGroupCount", this.RunningGroupCount);
            this.SetParamSimple(map, prefix + "AbnormalCount", this.AbnormalCount);
            this.SetParamSimple(map, prefix + "ImageTagCount", this.ImageTagCount);
        }
    }
}

