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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResizeInstanceDisksRequest : AbstractModel
    {
        
        /// <summary>
        /// 待操作的实例ID。可通过[ DescribeInstances ](https://cloud.tencent.com/document/api/213/15728)接口返回值中的`InstanceId`获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 待扩容的数据盘配置信息，仅支持指定待扩容盘的目的容量。只支持扩容非弹性数据盘（[ DescribeDisks ](https://cloud.tencent.com/document/api/362/16315)接口返回值中的`Portable`为`false`表示非弹性）。数据盘容量单位：GiB。最小扩容步长：10GiB。关于数据盘类型的选择请参考[硬盘产品简介](https://cloud.tencent.com/document/product/362/2353)。可选数据盘类型受到实例类型`InstanceType`限制。另外允许扩容的最大容量也因数据盘类型的不同而有所差异。
        /// <dx-alert infotype="explain" title="">您必须指定参数DataDisks与SystemDisk的其中一个，但不能同时指定。</dx-alert>
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// 是否对运行中的实例选择强制关机。建议对运行中的实例先手动关机，然后再扩容实例磁盘。取值范围：<br><li>true：表示在正常关机失败后进行强制关机</li><br><li>false：表示在正常关机失败后不进行强制关机</li><br><br>默认取值：false。<br><br>强制关机的效果等同于关闭物理计算机的电源开关。强制关机可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常关机时使用。
        /// </summary>
        [JsonProperty("ForceStop")]
        public bool? ForceStop{ get; set; }

        /// <summary>
        /// 待扩容的系统盘配置信息，仅支持指定待扩容盘的目的容量。只支持扩容云盘。
        /// <dx-alert infotype="explain" title="">您必须指定参数DataDisks与SystemDisk的其中一个，但不能同时指定。</dx-alert>
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// 扩容云盘的方式是否为在线扩容。
        /// </summary>
        [JsonProperty("ResizeOnline")]
        public bool? ResizeOnline{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamSimple(map, prefix + "ForceStop", this.ForceStop);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamSimple(map, prefix + "ResizeOnline", this.ResizeOnline);
        }
    }
}

