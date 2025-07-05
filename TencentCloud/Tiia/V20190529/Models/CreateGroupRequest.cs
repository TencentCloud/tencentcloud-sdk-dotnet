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

namespace TencentCloud.Tiia.V20190529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 图库ID，不可重复，仅支持字母、数字和下划线。图库数量单个用户上限为30。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 图库名称描述。
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 图片库可容纳的最大图片特征条数，一张图片对应一条图片特征数据，不支持修改。
        /// 单个图片库容量最大可达亿级，达到容量限制后继续创建图片将会报错。
        /// 注意，包月计费下支持绑定的最小库容量为500万。
        /// </summary>
        [JsonProperty("MaxCapacity")]
        public ulong? MaxCapacity{ get; set; }

        /// <summary>
        /// 图库简介。
        /// </summary>
        [JsonProperty("Brief")]
        public string Brief{ get; set; }

        /// <summary>
        /// 访问限制默认为10qps，如需扩容请联系[在线客服](https://cloud.tencent.com/online-service)申请。
        /// </summary>
        [JsonProperty("MaxQps")]
        public ulong? MaxQps{ get; set; }

        /// <summary>
        /// 图库类型，用于决定图像搜索的服务类型和算法版本，默认为4。
        /// GroupType不支持修改，若不确定适用的服务类型，建议先对不同类型分别小规模测试后再开始正式使用。
        /// 参数取值：
        /// 4：通用图像搜索1.0版。
        /// 8：商品图像搜索3.0升级版。
        /// 7：商品图像搜索2.0版。
        /// 5：商品图像搜索1.0版。
        /// 6：图案花纹搜索1.0版。
        /// 1 - 3：通用图像搜索旧版，不推荐使用。
        /// </summary>
        [JsonProperty("GroupType")]
        public ulong? GroupType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "MaxCapacity", this.MaxCapacity);
            this.SetParamSimple(map, prefix + "Brief", this.Brief);
            this.SetParamSimple(map, prefix + "MaxQps", this.MaxQps);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
        }
    }
}

