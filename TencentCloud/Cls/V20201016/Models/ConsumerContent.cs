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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConsumerContent : AbstractModel
    {
        
        /// <summary>
        /// 是否投递 TAG 信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableTag")]
        public bool? EnableTag{ get; set; }

        /// <summary>
        /// 需要投递的元数据列表，目前仅支持：\_\_SOURCE\_\_，\_\_FILENAME\_\_和\_\_TIMESTAMP\_\_
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetaFields")]
        public string[] MetaFields{ get; set; }

        /// <summary>
        /// 当EnableTag为true时，必须填写TagJsonNotTiled字段，TagJsonNotTiled用于标识tag信息是否json平铺，TagJsonNotTiled为true时不平铺，false时平铺
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagJsonNotTiled")]
        public bool? TagJsonNotTiled{ get; set; }

        /// <summary>
        /// 投递时间戳精度，可选项 [1:秒；2:毫秒] ，默认是秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimestampAccuracy")]
        public long? TimestampAccuracy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableTag", this.EnableTag);
            this.SetParamArraySimple(map, prefix + "MetaFields.", this.MetaFields);
            this.SetParamSimple(map, prefix + "TagJsonNotTiled", this.TagJsonNotTiled);
            this.SetParamSimple(map, prefix + "TimestampAccuracy", this.TimestampAccuracy);
        }
    }
}

