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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LakeFsInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>托管存储名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>托管存储类型</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>存储用量</p>
        /// </summary>
        [JsonProperty("SpaceUsedSize")]
        public float? SpaceUsedSize{ get; set; }

        /// <summary>
        /// <p>创建时候的时间戳</p>
        /// </summary>
        [JsonProperty("CreateTimeStamp")]
        public long? CreateTimeStamp{ get; set; }

        /// <summary>
        /// <p>是否是用户默认桶，0：默认桶，1：非默认桶</p>
        /// </summary>
        [JsonProperty("DefaultBucket")]
        public long? DefaultBucket{ get; set; }

        /// <summary>
        /// <p>托管存储short name</p>
        /// </summary>
        [JsonProperty("ShortName")]
        public string ShortName{ get; set; }

        /// <summary>
        /// <p>桶描述信息</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>托管桶状态，当前取值为：creating、bind、readOnly、isolate</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>托管存储桶标签列表</p>
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }

        /// <summary>
        /// <p>是否是多AZ存储桶</p>
        /// </summary>
        [JsonProperty("MultiAZ")]
        public bool? MultiAZ{ get; set; }

        /// <summary>
        /// <p>存储桶配置信息</p>
        /// </summary>
        [JsonProperty("Configuration")]
        public KVPair[] Configuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SpaceUsedSize", this.SpaceUsedSize);
            this.SetParamSimple(map, prefix + "CreateTimeStamp", this.CreateTimeStamp);
            this.SetParamSimple(map, prefix + "DefaultBucket", this.DefaultBucket);
            this.SetParamSimple(map, prefix + "ShortName", this.ShortName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "MultiAZ", this.MultiAZ);
            this.SetParamArrayObj(map, prefix + "Configuration.", this.Configuration);
        }
    }
}

