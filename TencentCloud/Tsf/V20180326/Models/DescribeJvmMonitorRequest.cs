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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeJvmMonitorRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询的实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例所属应用Id
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 时间粒度,单位:秒
        /// </summary>
        [JsonProperty("TimeGranularity")]
        public long? TimeGranularity{ get; set; }

        /// <summary>
        /// 查询数据起始时间格式(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// 查询数据结束时间格式(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [JsonProperty("To")]
        public string To{ get; set; }

        /// <summary>
        /// 查询的监控图列表,以返回值属性名作为入参
        /// </summary>
        [JsonProperty("RequiredPictures")]
        public string[] RequiredPictures{ get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "TimeGranularity", this.TimeGranularity);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
            this.SetParamArraySimple(map, prefix + "RequiredPictures.", this.RequiredPictures);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
        }
    }
}

