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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNodesRequest : AbstractModel
    {
        
        /// <summary>
        /// 节点类型
        /// <li> 1 = IDC </li>
        /// <li> 2 = LastMile </li>
        /// <li> 3 = Mobile </li>
        /// </summary>
        [JsonProperty("NodeType")]
        public long? NodeType{ get; set; }

        /// <summary>
        /// 节点区域
        /// <li> 1 = 中国大陆 </li>
        /// <li> 2 = 港澳台 </li>
        /// <li> 3 = 境外</li>
        /// </summary>
        [JsonProperty("Location")]
        public long? Location{ get; set; }

        /// <summary>
        /// 是否IPv6
        /// </summary>
        [JsonProperty("IsIPv6")]
        public bool? IsIPv6{ get; set; }

        /// <summary>
        /// 名字模糊搜索
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 付费模式
        /// <li>1 = 试用版本</li>
        /// <li> 2 = 付费版本 </li>
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 任务类型
        /// <li>1 = 页面性能</li>
        /// <li>2 = 文件上传</li>
        /// <li>3 = 文件下载</li>
        /// <li>4 = 端口性能</li>
        /// <li>5 = 网络质量</li>
        /// <li>6 = 音视频体验</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "IsIPv6", this.IsIPv6);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
        }
    }
}

