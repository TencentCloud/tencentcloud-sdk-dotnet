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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OSImage : AbstractModel
    {
        
        /// <summary>
        /// os聚合名称
        /// </summary>
        [JsonProperty("SeriesName")]
        public string SeriesName{ get; set; }

        /// <summary>
        /// os别名
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// os名称
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// 操作系统类型(分为定制和非定制，取值分别为:DOCKER_CUSTOMIZE、GENERAL)
        /// </summary>
        [JsonProperty("OsCustomizeType")]
        public string OsCustomizeType{ get; set; }

        /// <summary>
        /// os是否下线(online表示在线,offline表示下线)
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 镜像id
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SeriesName", this.SeriesName);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "OsCustomizeType", this.OsCustomizeType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
        }
    }
}

