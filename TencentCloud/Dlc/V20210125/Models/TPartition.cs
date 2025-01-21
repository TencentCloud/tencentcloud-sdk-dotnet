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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TPartition : AbstractModel
    {
        
        /// <summary>
        /// 字段名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 字段类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 字段描述
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 分区类型（已废弃）
        /// </summary>
        [JsonProperty("PartitionType")]
        public string PartitionType{ get; set; }

        /// <summary>
        /// 分区格式（已废弃）
        /// </summary>
        [JsonProperty("PartitionFormat")]
        public string PartitionFormat{ get; set; }

        /// <summary>
        /// 分区分隔数（已废弃）
        /// </summary>
        [JsonProperty("PartitionDot")]
        public long? PartitionDot{ get; set; }

        /// <summary>
        /// 分区转换策略
        /// </summary>
        [JsonProperty("Transform")]
        public string Transform{ get; set; }

        /// <summary>
        /// 策略参数
        /// </summary>
        [JsonProperty("TransformArgs")]
        public string[] TransformArgs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "PartitionType", this.PartitionType);
            this.SetParamSimple(map, prefix + "PartitionFormat", this.PartitionFormat);
            this.SetParamSimple(map, prefix + "PartitionDot", this.PartitionDot);
            this.SetParamSimple(map, prefix + "Transform", this.Transform);
            this.SetParamArraySimple(map, prefix + "TransformArgs.", this.TransformArgs);
        }
    }
}

