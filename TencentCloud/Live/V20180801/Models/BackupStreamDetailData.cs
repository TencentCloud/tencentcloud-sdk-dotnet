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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupStreamDetailData : AbstractModel
    {
        
        /// <summary>
        /// 推流域名。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 推流路径。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        ///  UTC 格式，例如：2018-06-29T19:00:00Z。
        /// 注意：和北京时间相差8小时。
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// 推流唯一标识。
        /// </summary>
        [JsonProperty("UpstreamSequence")]
        public string UpstreamSequence{ get; set; }

        /// <summary>
        /// 推流来源。示例：
        /// 直推流；
        /// 拉流转推(1234)；
        /// 注意：拉流转推来源括号中为拉流转推的任务 
        ///  ID。
        /// </summary>
        [JsonProperty("SourceFrom")]
        public string SourceFrom{ get; set; }

        /// <summary>
        /// 主备标识。
        /// 当前流为主流：1，
        /// 当前流为备流: 0。
        /// </summary>
        [JsonProperty("MasterFlag")]
        public long? MasterFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "UpstreamSequence", this.UpstreamSequence);
            this.SetParamSimple(map, prefix + "SourceFrom", this.SourceFrom);
            this.SetParamSimple(map, prefix + "MasterFlag", this.MasterFlag);
        }
    }
}

