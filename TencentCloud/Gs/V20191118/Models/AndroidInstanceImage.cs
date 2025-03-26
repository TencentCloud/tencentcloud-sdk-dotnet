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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AndroidInstanceImage : AbstractModel
    {
        
        /// <summary>
        /// 镜像 ID
        /// </summary>
        [JsonProperty("AndroidInstanceImageId")]
        public string AndroidInstanceImageId{ get; set; }

        /// <summary>
        /// 镜像名称，由业务方自定义，仅用于展示
        /// </summary>
        [JsonProperty("AndroidInstanceImageName")]
        public string AndroidInstanceImageName{ get; set; }

        /// <summary>
        /// 镜像状态
        /// </summary>
        [JsonProperty("AndroidInstanceImageState")]
        public string AndroidInstanceImageState{ get; set; }

        /// <summary>
        /// 镜像可用区
        /// </summary>
        [JsonProperty("AndroidInstanceImageZone")]
        public string AndroidInstanceImageZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AndroidInstanceImageId", this.AndroidInstanceImageId);
            this.SetParamSimple(map, prefix + "AndroidInstanceImageName", this.AndroidInstanceImageName);
            this.SetParamSimple(map, prefix + "AndroidInstanceImageState", this.AndroidInstanceImageState);
            this.SetParamSimple(map, prefix + "AndroidInstanceImageZone", this.AndroidInstanceImageZone);
        }
    }
}

