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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceDiskInfo : AbstractModel
    {
        
        /// <summary>
        /// 平均每秒有百分之几的时间用于IO操作
        /// </summary>
        [JsonProperty("IoRatioPerSec")]
        public long?[] IoRatioPerSec{ get; set; }

        /// <summary>
        /// 平均每次设备I/O操作的等待时间*100，单位为毫秒。例如：该值为201，表示平均每次I/O操作等待时间为：201/100=2.1毫秒
        /// </summary>
        [JsonProperty("IoWaitTime")]
        public long?[] IoWaitTime{ get; set; }

        /// <summary>
        /// 磁盘平均每秒完成的读操作次数总和*100。例如：该值为2002，表示磁盘平均每秒完成读操作为：2002/100=20.2次
        /// </summary>
        [JsonProperty("Read")]
        public long?[] Read{ get; set; }

        /// <summary>
        /// 磁盘平均每秒完成的写操作次数总和*100。例如：该值为30001，表示磁盘平均每秒完成写操作为：30001/100=300.01次
        /// </summary>
        [JsonProperty("Write")]
        public long?[] Write{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "IoRatioPerSec.", this.IoRatioPerSec);
            this.SetParamArraySimple(map, prefix + "IoWaitTime.", this.IoWaitTime);
            this.SetParamArraySimple(map, prefix + "Read.", this.Read);
            this.SetParamArraySimple(map, prefix + "Write.", this.Write);
        }
    }
}

