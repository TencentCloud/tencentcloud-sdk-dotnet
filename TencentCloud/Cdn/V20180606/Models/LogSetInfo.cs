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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogSetInfo : AbstractModel
    {
        
        /// <summary>
        /// 开发者ID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 渠道
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// 日志集ID
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// 日志集名字
        /// </summary>
        [JsonProperty("LogsetName")]
        public string LogsetName{ get; set; }

        /// <summary>
        /// 是否默认日志集
        /// </summary>
        [JsonProperty("IsDefault")]
        public ulong? IsDefault{ get; set; }

        /// <summary>
        /// 日志保存时间，单位为天
        /// </summary>
        [JsonProperty("LogsetSavePeriod")]
        public ulong? LogsetSavePeriod{ get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "LogsetName", this.LogsetName);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "LogsetSavePeriod", this.LogsetSavePeriod);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Region", this.Region);
        }
    }
}

